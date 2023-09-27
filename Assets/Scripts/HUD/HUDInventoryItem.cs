using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDInventoryItem : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI ammountText;

    public void Setup(Sprite sprite, int ammount)
    {
        itemImage.sprite = sprite;
        ammountText.text = ammount.ToString();
    }

    public void UpdateAmmount(int ammount)
    {
        ammountText.text = ammount.ToString();
    }
}
