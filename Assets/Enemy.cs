using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player playerVar;
    public int enemysCount = 10;
    private string name;
    // Start is called before the first frame update
    void Start()
    {
        name = playerVar.playerName;
        Debug.Log("I'm your enemy, " + name);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemysCount != 10)
        {
            Debug.Log(playerVar.playerName + " hit me!");
            enemysCount = 10;
        }
        
    }
}
