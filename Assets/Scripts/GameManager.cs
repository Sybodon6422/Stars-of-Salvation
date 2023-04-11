using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    public ShipStats shipStats;
    public Astronaut[] astronauts;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            
        }
        else
        {
            _instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private GameSaveData saveFile;
    public void SetGameSave(GameSaveData _saveFile)
    {
        saveFile = _saveFile;
        shipStats = _saveFile.shipStatsSave;
        astronauts = new Astronaut[_saveFile.nauts.Length];
        for (int i = 0; i < _saveFile.nauts.Length; i++)
        {
            astronauts[i] = new Astronaut(_saveFile.nauts[i]);
        }

        SceneManager.LoadScene("GamePlay");
    }

    public void GameLoaded()
    {
        AstronautsPanel.Instance.SetupAstronauts(astronauts);
    }

    public void SaveGame()
    {
        GameDataHandler saveDaveHandle = new();

        saveFile.shipStatsSave = shipStats;
        saveFile.nauts = SaveNauts();

        saveDaveHandle.SaveGame(saveFile);
    }
    AstronautSave[] SaveNauts()
    {
        AstronautSave[] astrosSave = new AstronautSave[astronauts.Length];
        for (int i = 0; i < astronauts.Length; i++)
        {
            astrosSave[i] = astronauts[i].ToSave();
        }
        return astrosSave;
    }
}
