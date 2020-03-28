using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject[] tiles;

    private int height;
    private int width;

    private int[,] grid = { 
        { 0, 1, 0, 0, -1, -1, -1 }, 
        { 0, 1, 0, 0, 0, 1, 0 }, 
        { 0, 1, 0, 0, 0, 1, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int i = 0; i < grid.GetLength(1); i++)
        {
            for (int j = 0; j < grid.GetLength(2); j++)
            {
                Vector3 pos = new Vector3(j, i, 0);
                Quaternion rot = Quaternion.identity;
                Instantiate(tiles[grid[i, j]], pos, rot);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
