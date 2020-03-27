using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
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
        //grid = { { 0, 1, 0, 0, -1, -1, -1},{ 0, 1, 0, 0, 0, 1, 0},{ 0, 1, 0, 0, 0, 1, 0} };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
