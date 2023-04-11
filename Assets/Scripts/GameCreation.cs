using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameCreation : MonoBehaviour
{
    public AstronautPanelPiece[] astronautPanelPieces;

    public TextMeshProUGUI saveNameText;

    public GameObject panelPiece;
    AstronautSave[] astros;

    public int astronautAmmount =3;

    private void Start()
    {
        astronautPanelPieces = new AstronautPanelPiece[astronautAmmount];
        for (int i = 0; i < 5; i++)
        {
            GameObject go = Instantiate(panelPiece, transform);
            astronautPanelPieces[i] = go.GetComponent<AstronautPanelPiece>();
        }

        GenerateNewAstros();
    }

    public void GenerateNewAstros()
    {
        astros = new AstronautSave[astronautAmmount];
        for (int i = 0; i < astronautAmmount; i++)
        {
            astros[i] = new AstronautSave(
                GetRandomName(),
                new ColourSerializable(Random.ColorHSV()),
                new Skills()
                );

            astronautPanelPieces[i].UpdatePiece(astros[i]);
        }
    }

    public string GetRandomName()
    {
        string astroNameFirst, astroNameLast;

        astroNameFirst = firstNamesList[Random.Range(0,firstNamesList.Length)];
        astroNameLast = lastNamesList[Random.Range(0, lastNamesList.Length)];

        return astroNameFirst + " " + astroNameLast; 
    }

    readonly string[] firstNamesList = new string[] { "Rat", "Donk", "Dave", "Bill", "Roger", "Elliot", "Spencer", "Gally", "Peter", "Sally", "Jade", "Mathew", "Cassie", 
        "Jabanjelino","Reggie", "CatHead","Sam", "Skippy","Leela","Zap" };
    readonly string[] lastNamesList = new string[] { "Barker", "Johnson", "Tedward", "RatChild", "FungusBoy", "Terrible", "TheWorst","Constable","leasure","Branigan", "Fry","Smith",
        "Guppy","SlurpDog", "Galliger", "Beghetti"};

    public void FinishGameCreation()
    {
        string saveText = saveNameText.text;
        if(saveText.Length < 3)
        {
            saveText = Random.Range(10000, 99999).ToString();
        }
        GameDataHandler dataHandler = new GameDataHandler();
        dataHandler.SaveGame(astros, saveText);
    }
}
