using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameSaveData
{
    public AstronautSave[] nauts;
    public ShipStats shipStatsSave;
    public string saveName;

    public GameSaveData(AstronautSave[] _nauts, String _saveName)
    {
        this.nauts = _nauts;
        this.saveName = _saveName;
    }
    public GameSaveData(AstronautSave[] _nauts, String _saveName,ShipStats _shipStatsSave)
    {
        this.nauts = _nauts;
        this.saveName = _saveName;
        this.shipStatsSave = _shipStatsSave;
    }
}

[Serializable]
public class ColourSerializable
{
    public float red, green, blue;

    public Color ConvertToColor()
    {
        Color color = new Color(red, green, blue);
        return color;
    }

    public ColourSerializable(Color color)
    {
        this.red = color.r;
        this.green = color.g;
        this.blue = color.b;
    }
}
