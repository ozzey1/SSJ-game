﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public string[] charNames;

    public GameObject[] characters;
    public GameObject turtle;

    public void Defeat()
    {
        GameOver();
    }

    public void CheckVictory() { AllTogether(); }

    public int charNameToIndex(string name)
    {
        int index = -1;
        for (int i = 0; i < charNames.Length; i++) if (charNames[i] == name) index = i;
        return index;
    }
    public bool Combine(GameObject charA, GameObject charB)
    {
        int a = charNameToIndex(charA.name);
        int b = charNameToIndex(charB.name);

        if (a * b < 0) return false;
        if (combineMatrix[a, b] < 0) return false;

        Vector2 pos = charA.transform.position;
        Quaternion rot = charA.transform.rotation;
        Destroy(charA);
        Destroy(charB);
        Instantiate(characters[combineMatrix[a, b]], pos, rot);

        return true;
    }

    private int[,] combineMatrix =
    {
        {-1,2},
        {2,-1}
    };

    private void GameOver() { Debug.Log("Game Over"); }

    private void Victory() { Debug.Log("You Win!!!"); }

    private bool AllTogether()
    {
        Vector3 coordinates = Vector3.zero;
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == 0) coordinates = characters[i].transform.position;
            else if (coordinates != characters[i].transform.position) return false;
        }
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
   
}

