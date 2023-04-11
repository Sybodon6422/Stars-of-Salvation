using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuManager : MonoBehaviour
{
    public GameObject shipMenu, mapMenu, researchMenu;
    public void OpenShipMenu()
    {
        shipMenu.SetActive(true);
        mapMenu.SetActive(false);
        researchMenu.SetActive(false);
    }
    public void OpenMapMenu()
    {
        shipMenu.SetActive(false);
        mapMenu.SetActive(true);
        researchMenu.SetActive(false);
    }
    public void OpenResearchMenu()
    {
        shipMenu.SetActive(false);
        mapMenu.SetActive(false);
        researchMenu.SetActive(true);
    }

    public GameObject choiceSubMenu, miningSubMenu;
    public void OpenChoiceSubMenu() { miningSubMenu.SetActive(false); choiceSubMenu.SetActive(true); }
    public void OpenMiningSubMenu() { miningSubMenu.SetActive(true); choiceSubMenu.SetActive(false); }

    public void SaveGame() { GameManager.Instance.SaveGame(); }
}
