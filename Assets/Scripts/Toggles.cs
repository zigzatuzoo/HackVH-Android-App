using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggles : TimerMath
{
    // Start is called before the first frame update
    
    
    public Toggle inGameHourToggle;
    public Toggle inGameMinuteToggle;
  
    

    private void Start()
     {
        Button subbtn = submitButton.GetComponent<Button>();
        subbtn.onClick.AddListener(submit);
        startButton.interactable = false;

        //Debug.Log("value = " + inGameHourToggle.isOn);

    }

     //Use buttons linked to this
     public void ChangeValueToTrue(Toggle aToggle)
     {
         aToggle.GetComponent<Toggle>().isOn = true;
     }
 
     //Use buttons linked to this
     public void ChangeValueToFalse(Toggle aToggle)
     {
         aToggle.GetComponent<Toggle>().isOn = false;
     }

    // Update is called once per frame
    void Update()
    {
        whatToggleOn();
        
    }

    
    void whatToggleOn()
    {
        if (inGameMinuteToggle.isOn)
        {
            ChangeValueToFalse(inGameHourToggle);
            //inGameHourToggle.isOn = false;
            

        }
        if (inGameHourToggle.isOn)
        {
            ChangeValueToFalse(inGameMinuteToggle);
            //inGameMinuteToggle.isOn = false;
            
            
        }
    }
    
    
    new public void submit()
    {
        if( inGameMinuteToggle.isOn == false && inGameHourToggle.isOn == false )
        {
            int intBreakLength;
            int intNumBreaks;
            int intStudyTime;
            intBreakLength = int.Parse(breakLength.text);
            intNumBreaks = int.Parse(numOfBreaks.value.ToString());
            intStudyTime = int.Parse(studyTime.text);
            Debug.Log(intStudyTime);
            Debug.Log(intBreakLength);

            double math = (intStudyTime / (intNumBreaks + 1)) - (intBreakLength / 2);
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
        }
        else if (inGameHourToggle.isOn)
        {
            int intBreakLength;
            int intNumBreaks;
            int intStudyTime;
            intBreakLength = int.Parse(breakLength.text);
            intNumBreaks = int.Parse(numOfBreaks.value.ToString());
            intStudyTime = int.Parse(studyTime.text);
            Debug.Log(intStudyTime);
            Debug.Log(intBreakLength);

            string display = "";

            while (intStudyTime > 50)
            {
                display = display.ToString() + "50" + " Minutes" + "\n";
                display = display.ToString() + "10" + " Minutes" + "\n";
                intStudyTime -= 50;
            }
            if (intStudyTime > 0 && intStudyTime <= 50)
            {
                display = display.ToString() + intStudyTime + " Minutes";
                //Debug.Log("Minutes left:" + intStudyTime);
            }
            output.text = display;
            time = display;

            startButton.interactable = true;
            Button btn = startButton;
            btn.onClick.AddListener(toTimer);

        }
        else if (inGameMinuteToggle.isOn)
        {
            int intBreakLength;
            int intNumBreaks;
            int intStudyTime;
            intBreakLength = int.Parse(breakLength.text);
            intNumBreaks = int.Parse(numOfBreaks.value.ToString());
            intStudyTime = int.Parse(studyTime.text);
            Debug.Log(intStudyTime);
            Debug.Log(intBreakLength);

            int k = intStudyTime;

            string display = "";

            while (k > 25)
            {
                display = display.ToString() + "25" + " Minutes" + "\n";
                display = display.ToString() + "5" + " Minutes" + "\n";
                k -= 25;
            }
            if (k > 0 && k <= 25)
            {
                display = display.ToString() + k + " Minutes";
                //Debug.Log("Minutes left:" + intStudyTime);
            }
            output.text = display;
            time = display;

            startButton.interactable = true;
            Button btn = startButton;
            btn.onClick.AddListener(toTimer);
        }
        
    }

}
