using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoiceMaker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI choice1, choice2, choice3;

    public void SetChoice1(string choiceText) { choice1.text = choiceText; }
    public void SetChoice2(string choiceText) { choice2.text = choiceText; }
    public void SetChoice3(string choiceText) { choice3.text = choiceText; }
    public void PickChoice1() { }
    public void PickChoice2() { }
    public void PickChoice3() { }

    public void HideChoices(int showNum)
    {
        switch (showNum)
        {
            case 0:
                choice1.transform.parent.gameObject.SetActive(false);
                choice2.transform.parent.gameObject.SetActive(false);
                choice3.transform.parent.gameObject.SetActive(false);
                break;
            case 1:
                choice1.transform.parent.gameObject.SetActive(true);
                choice2.transform.parent.gameObject.SetActive(false);
                choice3.transform.parent.gameObject.SetActive(false);
                break;
            case 2:
                choice1.transform.parent.gameObject.SetActive(true);
                choice2.transform.parent.gameObject.SetActive(true);
                choice3.transform.parent.gameObject.SetActive(false);
                break;
            case 3:
                choice1.transform.parent.gameObject.SetActive(true);
                choice2.transform.parent.gameObject.SetActive(true);
                choice3.transform.parent.gameObject.SetActive(true);
                break;

            default:
                break;
        }
    }
}
