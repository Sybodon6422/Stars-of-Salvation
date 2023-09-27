using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MiningWorldManager : MonoBehaviour
{
    #region singleton
    private static MiningWorldManager _instance;
    public static MiningWorldManager I { get { return _instance; } }

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
    }
    #endregion

    [SerializeField] private Tilemap tileMap;
    private TilemapCollider2D collision;
    private MiningWorldGeneration generator;


    [SerializeField] private int mapWidth = 30;
    public void SetMapHeight(int mapHeightNew) { mapHeight = mapHeightNew; }
    [SerializeField] private GameObject BG;
    private int mapHeight;
    [SerializeField] private GameObject upgradeHut;
    public Layer[] worldLayers;
    [SerializeField] GameObject playerFab;
    TileBlockData[,] worldTiles;
    public void GenerateWorld()
    {
        tileMap.ClearAllTiles();
        generator = new MiningWorldGeneration();
        worldTiles = generator.GenerateMap(worldLayers,mapWidth,this);

        BG.transform.position = new Vector3Int(0, mapHeight, 0);
        //place upgrade hut and mark tiles under it as industructible
        Instantiate(upgradeHut, new Vector3(0+1, mapHeight, 0), Quaternion.identity);
        for (int i = 0; i < 8; i++)
        {
            worldTiles[i+1, mapHeight-1].impregnable = true;
        }

        //mark bottom of world impregnable
        for (int i = 0; i < mapWidth; i++)
        {
            worldTiles[i, 0].impregnable = true;
        }

        GameStart();
    }

    public void GenerateWorldEditor()
    {
        tileMap.ClearAllTiles();
        generator = new MiningWorldGeneration();
        worldTiles = generator.GenerateMap(worldLayers,mapWidth,this);

        BG.transform.position = new Vector3Int(0, mapHeight, 0);
    }

    public void GameStart()
    {
        Instantiate(playerFab, new Vector3(0 + 6, mapHeight + 1, 0), Quaternion.identity);
    }

    private TileBlockData minedBlock;
    public void MineTile(Vector2Int pos, Inventory inventory, int damage)
    {
        Vector2Int fixedPos = new Vector2Int(pos.x, pos.y);
        Vector3Int secondaryFixedPos = new Vector3Int(pos.x, pos.y, 0);
        if (worldTiles[pos.x, pos.y].impregnable) { return; }
        worldTiles[pos.x, pos.y].health -= damage;

        if(worldTiles[pos.x, pos.y].health <= 0)
        {
            if(dataTiles[worldTiles[pos.x, pos.y].tileID] != null)
            {
                inventory.AddToInventory(dataTiles[worldTiles[pos.x, pos.y].tileID],1);
                HUDMaster.I.UpdateInventoryDisplay(inventory);
            }

            tileMap.SetTile(secondaryFixedPos, null);
        }
    }

    private void TileInfoCheck(int tileID)
    {

    }

    #region tilePainting

    public void SetTile(Vector2Int tilePaintPosition, int tileID)
    {
        Vector3Int worldPos = new Vector3Int(tilePaintPosition.x, tilePaintPosition.y, 0);
        tileMap.SetTile(worldPos, dataTiles[tileID].itemTileSprite);
    }

    private void DestroyTile(Vector2Int tilePaintPosition)
    {
        Vector3Int worldPos = new Vector3Int(tilePaintPosition.x, tilePaintPosition.y, 0);
        tileMap.SetTile(worldPos, null);
    }

    #endregion

    public ItemSO GetDataFromID(int id){
        return dataTiles[id];
    }

    public ItemSO[] dataTiles;
    [Serializable]
    public class DataTileBlock
    {
        public int itemID;
        public int health;
        public Tile tile;
        public ItemSO item;

    }

    [Serializable]
    public struct Layer
    {
        public string layerName;

        public int layerBaseID;
        public ResourceChance[] layerResources;
        public int layerHeight;
    }

    [Serializable]
    public struct ResourceChance
    {
        //0 is impossible 100 is gaurteneed
        public float percentChance;
        public int oreID;
    }

    [Serializable]
    public struct TileBlockData
    {
        public TileBlockData(Vector2Int positionC, int healthC, int tileIDC)
        {
            this.position = positionC;
            this.health = healthC;
            this.tileID = tileIDC;
            impregnable = false;
        }
        public bool impregnable;
        public Vector2Int position;
        public int health;
        public int tileID;
    }
}
