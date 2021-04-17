using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourShow : MonoBehaviour
{
    //private float speed = 10f;
    //private float sliderVal = 0f;
    public Text sliderValue;
    public Slider slider;
    public float minStudy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //string sliderVal = slider.value.ToString("0.0");
        
        sliderValue.text = slider.value.ToString("0");
        OnValueChanged(slider.value);

    }
    public void OnValueChanged(float newValue)
    {
        minStudy = newValue;
        
    }




}
