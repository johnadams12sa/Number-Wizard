using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yo whaddup man, welcome to Number Wizard");
        Debug.Log("Pick a number, any number: ");
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Highest Number is: " + max);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number is higher than " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your number is lower than " + guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius! ");
        }
    }
}
