using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlManager : MonoBehaviour
{
    private ControlInterface inputActions;

    private Vector2 mousePos;

    public ShipMovement ourShip;

    public void StartGame() 
    {
        inputActions = new ControlInterface();
        inputActions.Enable();
        inputActions.miner.mouseClick.performed += ctx => Clicked();
        inputActions.miner.mousePosition.performed += ctx => mousePos = ctx.ReadValue<Vector2>();
    }

    void Clicked() 
    {
        ourShip.SetTarget(Camera.main.ScreenToWorldPoint(mousePos));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
