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
                UpdateSteps(1);

            }else
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                UpdateSteps(2);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                UpdateSteps(3);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                UpdateSteps(4);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                UpdateSteps(5);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                UpdateSteps(6);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                UpdateSteps(7);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                UpdateSteps(8);
            }else
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                UpdateSteps(9);
            }

            if (sum >= sumLimit)
            {
                Debug.Log(finish + sum);
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

    private void UpdateSteps(int count)
    {
        sum += count;
        stepsAmount++;
        if (sum < sumLimit) Debug.Log(sumFrase + sum.ToString());
    }
}
