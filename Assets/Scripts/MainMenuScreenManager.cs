using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreenManager : MonoBehaviour
{
    public void Continue()
    {
        GameDataHandler saveDaveHandle = new GameDataHandler();
        GameManager.Instance.SetGameSave(saveDaveHandle.LoadLastGame());
    }
}
