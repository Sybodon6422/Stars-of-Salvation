using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MiningWorldGeneration
{
    private MiningWorldManager.TileBlockData[,] m_blockData;

    public MiningWorldManager.TileBlockData[,] GenerateMap(MiningWorldManager.Layer[] worldLayers,int mapWidth, MiningWorldManager manager)
    {
        int heightCount = 0;
        for (int i = 0; i < worldLayers.Length; i++)
        {
            heightCount += worldLayers[i].layerHeight;
        }

        m_blockData = new MiningWorldManager.TileBlockData[mapWidth, heightCount];
        int currentYHeight = 0;
        for (int layer = 0; layer < worldLayers.Length; layer++)
        {
            for (int y = 0; y < worldLayers[layer].layerHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    int tileID = worldLayers[layer].layerBaseID;
                    for (int resourceI = 0; resourceI < worldLayers[layer].layerResources.Length; resourceI++)
                    {
                        var resource = worldLayers[layer].layerResources[resourceI];
                        float chance = UnityEngine.Random.Range(0, 101);
                        if (chance <= resource.percentChance) { tileID = resource.oreID; }
                        m_blockData[x, currentYHeight] = new MiningWorldManager.TileBlockData(
                            new Vector2Int(x, currentYHeight), 
                            manager.GetDataFromID(tileID).baseHealth + ((heightCount-currentYHeight)/10), 
                            tileID);
                        manager.SetTile(new Vector2Int(x, currentYHeight), tileID);
                    }
                }
                currentYHeight++;
            }
        }

        manager.SetMapHeight(currentYHeight);
        return m_blockData;
    }
}
