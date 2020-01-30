using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 1080;
    int currentNumber;
    int stepsAmount = 0;

    bool access = true;

    string hello = "Приветствую тебя, ";
    string playerName = "путник";
    string question = "Давай угадаю желаемое число?";
    string min = "От ";
    string max = " до ";
    string variant = "Твоё число ";
    string exit = "Хочешь закончить? Без проблем :)";
    string newGame = "Давай начнём заново, ";
    string steps = "Шагов понадобилось: ";

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(hello + playerName+"!");
        Debug.Log(question);
        Debug.Log(min + minNumber.ToString() + max + maxNumber.ToString()+".");
        UpdateNumber();
    }

    // Update is called once per frame
    void Update()
    {
        if (access)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minNumber = currentNumber;
                UpdateNumber();
            }
            else
            {

                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    maxNumber = currentNumber;
                    UpdateNumber();
                }
                else
                {

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        Debug.Log("УГАДАЛ!!!");
                        Debug.Log(steps + stepsAmount.ToString());
                        access = false;
                    }
                }
            }         
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                access = true;
                minNumber = 1;
                maxNumber = 1080;
                stepsAmount = 1;
                currentNumber = (minNumber + maxNumber) / 2;
                Debug.Log(newGame + playerName + "!");
                Debug.Log(question);
                Debug.Log(min + minNumber.ToString() + max + maxNumber.ToString() + ".");
                Debug.Log(variant + currentNumber.ToString() + "?");
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            access = false;
            Debug.Log(exit);
        }
    }

    private void UpdateNumber()
    {
        currentNumber = (minNumber + maxNumber) / 2;
        stepsAmount++;
        Debug.Log(variant + currentNumber.ToString() + "?");
    }
}
