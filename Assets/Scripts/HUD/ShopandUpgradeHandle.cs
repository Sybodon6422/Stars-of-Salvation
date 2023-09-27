using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopandUpgradeHandle : MonoBehaviour
{
    private MinerMovement miner;

    [SerializeField] private TextMeshProUGUI[] upgradeCostText;
    [SerializeField] private TextMeshProUGUI[] upgradeLvlText, upgradeStatsText;

    void Start()
    {
        upgradeLvl = new int[5];
        for (int i = 0; i < upgradeLvl.Length; i++)
        {
            upgradeLvl[i] = 0;
        }

        //display inital TextMesh Values
        for (int i = 0; i < upgradeLvlText.Length; i++)
        {
            upgradeLvlText[i].text = upgradeLvl[i] + " >> " + (upgradeLvl[i]+1);
            upgradeCostText[i].text = "$" + (15*(upgradeLvl[i]+1)).ToString();
        }
        //DISPLAY INTIAL STAT VALUES
        upgradeStatsText[0].text = "Mining Speed: " + miner.miningSpeed + " >> " + (miner.miningSpeed + .5f);
        upgradeStatsText[1].text = "Mining Damage: " + miner.minerDamage + " >> " + (miner.minerDamage + 1);
        upgradeStatsText[2].text = "Movement Speed: " + miner.speed + " >> " + (miner.speed + 1);
        upgradeStatsText[3].text = "Jetpack Accleration: " + miner.jetpackAccleration + " >> " + (miner.jetpackAccleration + 1);
        upgradeStatsText[4].text = "Jetpack Max Speed: " + miner.maximumJetPackSpeed + " >> " + (miner.maximumJetPackSpeed + 1);
        
    }

    public void OpenShop(MinerMovement miner)
    {
        this.miner = miner;
    }

    public void CloseShop()
    {
        miner = null;
    }

    //selling
    public void SellItem(ItemSO item)
    {
        if(miner.inventory.HasItem(item))
        {
        int itemAmmount = miner.inventory.ItemMatch(item).itemAmmount;
        if(miner.inventory.AttemptRemoveItem(item))
        {
            miner.cash += item.sellValue * itemAmmount;
            HUDMaster.I.UpdateInventoryDisplay(miner.inventory);
            HUDMaster.I.UpdateCashText(miner.cash);
        }
        }
    }

    private int[] upgradeLvl;

    public void BuyUpgrade(int upgradeIndex)
    {
        switch (upgradeIndex)
        {
            case 0 :
                if(miner.cash >= 15*(upgradeLvl[upgradeIndex]+1))
                {
                    miner.cash -= 15*(upgradeLvl[upgradeIndex]+1);
                    upgradeLvl[upgradeIndex]++;
                    miner.miningSpeed += .5f;

                    upgradeLvlText[upgradeIndex].text = upgradeLvl[upgradeIndex] + " >> " + (upgradeLvl[upgradeIndex]+1);
                    upgradeCostText[upgradeIndex].text = "$" + (15*(upgradeLvl[upgradeIndex]+1)).ToString();
                    upgradeStatsText[upgradeIndex].text = "Mining Speed: " + miner.miningSpeed + " >> " + (miner.miningSpeed + .5f);
                    HUDMaster.I.UpdateCashText(miner.cash);
                }
            break;
            case 1 :
                if(miner.cash >= 15*(upgradeLvl[upgradeIndex]+1))
                {
                    miner.cash -= 15*(upgradeLvl[upgradeIndex]+1);
                    upgradeLvl[upgradeIndex]++;
                    miner.minerDamage += 1;

                    upgradeLvlText[upgradeIndex].text = upgradeLvl[upgradeIndex] + " >> " + (upgradeLvl[upgradeIndex]+1);
                    upgradeCostText[upgradeIndex].text = "$" + (15*(upgradeLvl[upgradeIndex]+1)).ToString();
                    upgradeStatsText[upgradeIndex].text = "Mining Damage: " + miner.minerDamage + " >> " + (miner.minerDamage + 1);

                    HUDMaster.I.UpdateCashText(miner.cash);
                }

            break;
            case 2 :
                if(miner.cash >= 15*(upgradeLvl[upgradeIndex]+1))
                {
                    miner.cash -= 15*(upgradeLvl[upgradeIndex]+1);
                    upgradeLvl[upgradeIndex]++;
                    miner.speed += 1;

                    upgradeLvlText[upgradeIndex].text = upgradeLvl[upgradeIndex] + " >> " + (upgradeLvl[upgradeIndex]+1);
                    upgradeCostText[upgradeIndex].text = "$" + (15*(upgradeLvl[upgradeIndex]+1)).ToString();
                    upgradeStatsText[upgradeIndex].text = "Movement Speed: " + miner.speed + " >> " + (miner.speed + 1);

                    HUDMaster.I.UpdateCashText(miner.cash);
                }
                break;
            case 3 :
                if(miner.cash >= 15*(upgradeLvl[upgradeIndex]+1))
                {
                    miner.cash -= 15*(upgradeLvl[upgradeIndex]+1);
                    upgradeLvl[upgradeIndex]++;
                    miner.jetpackAccleration += 1;

                    upgradeLvlText[upgradeIndex].text = upgradeLvl[upgradeIndex] + " >> " + (upgradeLvl[upgradeIndex]+1);
                    upgradeCostText[upgradeIndex].text = "$" + (15*(upgradeLvl[upgradeIndex]+1)).ToString();
                    upgradeStatsText[upgradeIndex].text = "Jetpack Accleration: " + miner.jetpackAccleration + " >> " + (miner.jetpackAccleration + 1);

                    HUDMaster.I.UpdateCashText(miner.cash);
                }
                break;
                case 4:
                if(miner.cash >= 15*(upgradeLvl[upgradeIndex]+1))
                {
                    miner.cash -= 15*(upgradeLvl[upgradeIndex]+1);
                    upgradeLvl[upgradeIndex]++;
                    miner.maximumJetPackSpeed += 1;

                    upgradeLvlText[upgradeIndex].text = upgradeLvl[upgradeIndex] + " >> " + (upgradeLvl[upgradeIndex]+1);
                    upgradeCostText[upgradeIndex].text = "$" + (15*(upgradeLvl[upgradeIndex]+1)).ToString();
                    upgradeStatsText[upgradeIndex].text = "Jetpack Max Speed: " + miner.maximumJetPackSpeed + " >> " + (miner.maximumJetPackSpeed + 1);

                    HUDMaster.I.UpdateCashText(miner.cash);
                }
                break;
            default:
            break;
        }
    }
}
