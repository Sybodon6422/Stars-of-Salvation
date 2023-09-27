using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenuAttribute(fileName = "New Item", menuName = "Assets/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Tile itemTileSprite;

    public int baseHealth;

    public int sellValue;

    //make inspector preview icon the itemTileSprite.Sprite
}