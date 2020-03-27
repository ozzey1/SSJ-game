using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMechanism : MonoBehaviour
{

    public int gridW, gridH;
    int[,] tiles;
    GameObject[,] actualTiles;

    public GameObject tilePassable, tileWater;

    // Start is called before the first frame update
    void Start()
    {
        tiles = new int[gridW, gridH];
        actualTiles = new GameObject[gridW, gridH];
        for (int i = 0; i < gridW; i++) {
            for (int j = 0; j < gridH; j++)
            {
                tiles[i, j] = 0;
                if (Random.Range(0, 100) <= 30)
                {
                    tiles[i, j] = 1;

                }
            }
        }

        for (int i = 0; i < gridW; i++)
        {
            for (int j = 0; j < gridH; j++)
            {
                switch (tiles[i, j]) {

                    case 0:
                        GameObject tileP = GameObject.Instantiate(tilePassable);
                        tileP.transform.position = new Vector2(i, j);
                        actualTiles[i, j] = tileP;
                        break;
                    case 1:
                        GameObject tileW = GameObject.Instantiate(tileWater);
                        tileW.transform.position = new Vector2(i, j);
                        actualTiles[i, j] = tileW;
                        break;
                    default:
                        break;


                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
