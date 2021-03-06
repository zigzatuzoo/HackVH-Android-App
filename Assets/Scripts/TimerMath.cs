using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerMath : MonoBehaviour
{

    public InputField studyTime;
    public InputField breakLength;
    public Slider numOfBreaks;
    public Button submitButton;
    public ArrayList allTimes;
    public Text output;
    public Text slideroutput;
    public string time;
    public Button startButton;

    // Start is called before the first frame update

    void Update()
    {
        slideroutput.text = numOfBreaks.value.ToString();
    }

    void Start()
    {
        Button subbtn = submitButton.GetComponent<Button>();
        subbtn.onClick.AddListener(submit);
        startButton.interactable = false;
    }

    public void submit()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("submit button clicked");
        Debug.Log(studyTime.text);

        int intBreakLength;
        int intNumBreaks;
        int intStudyTime;
        intBreakLength = int.Parse(breakLength.text);
        intNumBreaks = int.Parse(numOfBreaks.value.ToString());
        intStudyTime = int.Parse(studyTime.text);
        Debug.Log(intStudyTime);
        Debug.Log(intBreakLength);

        float math = (intStudyTime / (intNumBreaks + 1)) - (intBreakLength / 2);
        Debug.Log(math);

        List<double> test = new List<double>();
        string display;

        int rep = 0;
        while (rep != intNumBreaks)
        {
            test.Add(math);
            test.Add(intBreakLength);
            rep = rep + 1;
        }
        test.Add(math);

        display = "";

        foreach (var num in test)
        {
            Debug.Log(num.ToString());
            display = display.ToString() + num.ToString() + " Minutes" + "\n";
        }
        output.text = display;
        time = display;

        startButton.interactable = true;
        Button btn = startButton;
        btn.onClick.AddListener(toTimer);

        

        PlayerPrefs.SetInt("breakLengthPref", intBreakLength);
        PlayerPrefs.SetInt("numBreakPref", intNumBreaks);
        PlayerPrefs.SetInt("studyTimePref", intStudyTime);
        PlayerPrefs.SetFloat("mathPref", math);

    }
    public void toTimer()
    {
        SceneManager.LoadScene("Timer");
    }
}