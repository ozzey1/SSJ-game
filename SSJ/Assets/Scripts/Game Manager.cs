using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] characters;

    public void Defeat()
    {
        GameOver();
    }

    public void CheckVictory() { AllTogether(); }

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
