using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AstronautSave
{
    public string astroName;
    public ColourSerializable astroColour;
    public Skills skills;

    public AstronautSave(string _name, ColourSerializable _color, Skills _skills)
    {
        this.astroName = _name;
        this.astroColour = _color;
        this.skills = _skills;
    }
}