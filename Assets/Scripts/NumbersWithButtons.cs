using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class NumbersWithButtons : MonoBehaviour
{
    public Text number;
    public Text info;
    public TextMeshProUGUI roundsCountText;

    public int startMinNumber = 1;
    public int startMaxNumber = 1000;

    int minNumber;
    int maxNumber;
    int currentNumber;
    int roundsCount;

    string helloText = " Загадай число из заданного диапазона.";
    string minNumberText = "\n Минимальное число  = ";
    string maxNumberText = "\n Максимальное число = ";


    void Start()
    {
        minNumber = startMinNumber;
        maxNumber = startMaxNumber;
        roundsCount = 0;
        roundsCountText.text = roundsCount.ToString();
        currentNumber = (startMinNumber + startMaxNumber) / 2;
        number.text = currentNumber.ToString();
        info.text = helloText + minNumberText + startMinNumber.ToString() + maxNumberText + startMaxNumber.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        } 
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            down();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            up();
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    public void up ()
    {
        minNumber = currentNumber;
        currentNumber = (minNumber + maxNumber) / 2;
        number.text = currentNumber.ToString();
        roundsCount++;
        roundsCountText.text = roundsCount.ToString();
    }

    public void down()
    {
        maxNumber = currentNumber;
        currentNumber = (minNumber + maxNumber) / 2;
        number.text = currentNumber.ToString();
        roundsCount++;
        roundsCountText.text = roundsCount.ToString();
    }

}
