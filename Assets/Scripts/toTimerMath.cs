using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toTimerMath : MonoBehaviour
{
    public Button startButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = startButton;
        btn.onClick.AddListener(toTimerMathScene);
    }

    void toTimerMathScene()
    {
        SceneManager.LoadScene("TimerMath");
    }
}
