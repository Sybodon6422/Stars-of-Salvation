using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

[Serializable]
public class AstronautPanelPiece : MonoBehaviour
{
    public TextMeshProUGUI nameText, taskText;
    public Image astronautPicture;

    public Astronaut astronaut;

    public void UpdatePiece(Astronaut astro)
    {
        nameText.text = astro.astroName;
        astronautPicture.color = astro.astroColour;
        astronaut = astro;
    }
    public void ChangeTask(String newText)
    {
        taskText.text = newText;
    }

    public void UpdatePiece(AstronautSave astro)
    {
        nameText.text = astro.astroName;
        astronautPicture.color = astro.astroColour.ConvertToColor();
    }
}
