using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerMovement : MonoBehaviour
{
    private ControlInterface controls;
    Rigidbody2D rb;
    [SerializeField]ParticleSystem ps;
    Vector2 movementVector;
    private Vector2 mineVector;

    public Inventory inventory;

    public bool canOpenShop = false;

    //STATS
    public float miningSpeed = .5f;
    public float maximumJetPackSpeed = 2, jetpackAccleration = 2;
    public float speed = 1;
    public int minerDamage = 1;
    public int cash = 0;

    private void Awake()
    {
        controls = new ControlInterface();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inventory = new Inventory();
        inventory.InitializeInventory();

        controls.miner.wasd.performed += ctx => movementVector = ctx.ReadValue<Vector2>();
        controls.miner.wasd.canceled += ctx => movementVector = Vector2.zero;

        controls.miner.miningDirection.performed += ctx => mineVector = ctx.ReadValue<Vector2>();
        controls.miner.miningDirection.canceled += ctx => mineVector = Vector2.zero;
        controls.miner.enteract.performed += ctx => AttemptShopOpen();

        Transform cam = Camera.main.transform;
        cam.parent = transform;
        cam.localPosition = new Vector3(0, 0, -10);

        HUDMaster.I.UpdateInventoryDisplay(inventory);
        HUDMaster.I.UpdateCashText(cash);
    }

    // Update is called once per frame
    private float currentMineCountDown = 0;
    void FixedUpdate()
    {
        Vector2 horizontalMovement = movementVector.x * (speed*10) * Vector2.right;
        Vector2 verticalMovement = movementVector.y * jetpackAccleration * Vector2.up;
        Vector2 finalizedMovement = horizontalMovement + verticalMovement;

        rb.AddForce(finalizedMovement);
        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -2-(speed/3), 2+(speed/3)), Mathf.Clamp(rb.velocity.y, -14, maximumJetPackSpeed), 0);

        currentMineCountDown = Mathf.Clamp(currentMineCountDown-= Time.deltaTime* miningSpeed,0,2);
        HUDMaster.I.UpdateMiningCoolDown(currentMineCountDown, 1);
        if (mineVector.x >.9f || mineVector.x <-.9f || mineVector.y > .9f || mineVector.y < -.9f){
        if(currentMineCountDown <= 0) { currentMineCountDown = 1f; Mine(); }
                }
    }

    private void AttemptShopOpen()
    {
        if (canOpenShop)
        {
            HUDMaster.I.ShowShop(this);
        }
    }

    private void Mine()
    {
            ps.Play();
            RaycastHit2D hit = Physics2D.Raycast(transform.position, mineVector);
            if (hit.collider != null)
            {
                Vector2Int hitpos = Vector2Int.FloorToInt(hit.point + mineVector);
                MiningWorldManager.I.MineTile(hitpos,inventory,minerDamage);
            }
    }

    void OnEnable()
    {
        controls.Enable();
    }

    private class TileBlockData
    {
        public Vector3Int position;
        public int health;
    }
}
