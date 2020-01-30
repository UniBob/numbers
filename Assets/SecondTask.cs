using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTask : MonoBehaviour
{
    int sum = 0;
    int stepsAmount = 0;
    int sumLimit = 53;

    string hello = "Сыграем в игру?";
    string sumFrase = "Текущая сумма: ";
    string finish = "Ты набрал нужную сумму. Поздравляю!";
    string steps = "Количество шагов: ";

    bool isGameRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hello);
        Debug.Log(sumFrase + sum.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameRunning)
        {


            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                sum++;
                stepsAmount++;
                if (sum<sumLimit) Debug.Log(sumFrase + sum.ToString());

            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                sum+=2;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                sum+=3;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                sum+=4;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                sum+=5;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                sum+=6;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                sum+=7; 
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                sum+=8;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                sum+=9;
                stepsAmount++;
                if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
            }
            if (sum >= sumLimit)
            {
                Debug.Log(finish);
                Debug.Log(steps + stepsAmount.ToString());
                isGameRunning = false;
            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGameRunning = true;
            sum = 0;
            stepsAmount = 0;
            Debug.Log(hello);
            Debug.Log(sumFrase + sum.ToString());
        }
    }
}
