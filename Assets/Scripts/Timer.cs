using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text currentstattext;
    public Button finishButton;
    public Button cancelButton;

    private int cyclesLeft;

    public int breakLengthInt;
    public int numBreaksInt;
    public int studyTimeInt;
    public float mathFloat;

    private void Awake()
    {
        breakLengthInt = PlayerPrefs.GetInt("breakLengthPref");
        numBreaksInt = PlayerPrefs.GetInt("numBreakPref");
        studyTimeInt = PlayerPrefs.GetInt("studyTimePref");
        mathFloat = PlayerPrefs.GetFloat("mathPref");

        Debug.Log("breakLengthInt " + breakLengthInt);
        Debug.Log("numBreaksInt " + numBreaksInt);
        Debug.Log("studyTimeInt " + studyTimeInt);
        Debug.Log("mathFloat" + mathFloat);

        timerIsRunning = true;
        timeRemaining = mathFloat;

        cyclesLeft = numBreaksInt * 2;
        currentstattext.text = "Study!";

        Button fnbtn = finishButton.GetComponent<Button>();
        fnbtn.onClick.AddListener(toMainMenu);

        Button cnbtn = cancelButton.GetComponent<Button>();
        cnbtn.onClick.AddListener(toTimerMath);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Switch2Stuff();
            }
        }
    }

    void Switch2Stuff()
    {
        cyclesLeft = cyclesLeft - 1;
        Debug.Log("onSwitch2stuff, current cyclesLeft:" + cyclesLeft);

        if(cyclesLeft == 0)
        {
            currentstattext.text = "Done!";
            finishButton.interactable = true;
            Debug.Log("done");
        }

        if(cyclesLeft % 2 == 0)
        {
            // even number so its a break
            timeRemaining = breakLengthInt * 60;
            timerIsRunning = true;
            Debug.Log("even session");
        }

        if(cyclesLeft % 2 == 1)
        {
            // odd number so its a study session
            timeRemaining = mathFloat * 60;
            timerIsRunning = true;
            Debug.Log("odd session");
        }
        else
        {
            Debug.LogError("something happened during Switch2Stuff");
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void toMainMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }
    void toTimerMath()
    {
        SceneManager.LoadScene("TimerMath");
    }
}