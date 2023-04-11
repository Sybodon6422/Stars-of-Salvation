using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Astronaut
{
    public string astroName;
    public Color astroColour;
    public Skills skills;

    public Astronaut(AstronautSave saveFile)
    {
        this.astroName = saveFile.astroName;
        this.astroColour = saveFile.astroColour.ConvertToColor();
        this.skills = saveFile.skills;
    }

    public AstronautSave ToSave()
    {
        AstronautSave astronautSavesave = new AstronautSave(astroName, new ColourSerializable(astroColour), skills);

        return astronautSavesave;
    }
}
