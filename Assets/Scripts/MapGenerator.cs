using System;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Texture2D map;
    public ColorToPrefab[] colorToPrefabs;

    void Start()
    {
        GeneratLevel();
    }

    private void GeneratLevel()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x,y);
            }
        }
    }

    private void GenerateTile(int x, int y)
    {
        Color colorpixel = map.GetPixel(x, y);

        if (colorpixel.a == 0)
        {
            return;
        }

        foreach (ColorToPrefab colorPr in colorToPrefabs)
        {
            Vector2 position = new Vector2(x, y);

            if (colorPr.color.Equals(colorpixel))
            {
              Instantiate(colorPr.prefab, position, Quaternion.identity, transform);
            }
        }
        Debug.Log(colorpixel);
    }
}
