using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDMaster : MonoBehaviour
{
    //singleton pattern
    #region singleton
    private static HUDMaster _instance;
    public static HUDMaster I { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else { _instance = this; }
    }

    #endregion

    [SerializeField] private RectTransform miningCoolDownbar;

    public void UpdateMiningCoolDown(float currentCoolDown, float maxCoolDown)
    {
        miningCoolDownbar.localScale = new Vector3(currentCoolDown / maxCoolDown, 1, 1);
    }

    //inventory
    [SerializeField] private GameObject inventoryItemPrefab;
    [SerializeField] private Transform inventoryParent;
    private List<HUDInventoryItem> inventoryItems = new List<HUDInventoryItem>();

    //update inventory display by getting Inventory Class

    public void UpdateInventoryDisplay(Inventory inventory)
    {
        //clear inventory display
        foreach (HUDInventoryItem item in inventoryItems)
        {
            Destroy(item.gameObject);
        }
        inventoryItems.Clear();

        //update inventory display
        foreach (InventoryItem item in inventory.GetInventory())
        {
            HUDInventoryItem newItem = Instantiate(inventoryItemPrefab, inventoryParent).GetComponent<HUDInventoryItem>();
            newItem.Setup(item.itemRef.itemTileSprite.sprite, item.itemAmmount);
            inventoryItems.Add(newItem);
        }
    }


    [SerializeField] private TextMeshProUGUI cashText;
    public void UpdateCashText(int money){
        cashText.text = money+"$";
    }

    //shop
    [SerializeField] private ShopandUpgradeHandle shopPanel;
    [SerializeField] private GameObject shop;

    public void ShowShop(MinerMovement miner)
    {
        shopPanel.OpenShop(miner);
        shop.SetActive(true);
    }

    public void HideShop()
    {
        shopPanel.CloseShop();
        shop.SetActive(false);
    }
}
