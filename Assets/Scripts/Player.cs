using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy enemyVar;
    public string playerName = "Timmy";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + playerName);
        Debug.Log("I have " + enemyVar.enemysCount + " enemyes");
        enemyVar.enemysCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
               
    }
}
