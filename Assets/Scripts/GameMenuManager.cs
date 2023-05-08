using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuManager : MonoBehaviour
{
    public GameObject[] menuList;
    public void OpenMainMenu()
    {
        for (int i = 0; i < menuList.Length; i++)
        {
            if(i == 0)
            {
                menuList[i].SetActive(true);
            }
            else
            {
                menuList[i].SetActive(false);
            }
        }
    }

    public void SaveGame() { GameManager.Instance.SaveGame(); }
}
