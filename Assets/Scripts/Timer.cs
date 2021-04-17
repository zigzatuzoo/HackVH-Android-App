using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public InputField studyStart;
    public InputField studyEnd;
    public Button submitButton;

    

    // Start is called before the first frame update
    void Start()
    {
        Button subbtn = submitButton.GetComponent<Button>();
        subbtn.onClick.AddListener(submit);
    }

    void submit()
    {
        Debug.Log("submit button clicked");
        Debug.Log(studyStart.text);
        Debug.Log(studyEnd.text);

        int intStudyStart;
        int intStudyEnd;
        intStudyStart = int.Parse(studyStart.text);
        intStudyEnd = int.Parse(studyEnd.text);

        int totalTime = intStudyEnd - intStudyStart;

        Debug.Log(totalTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
