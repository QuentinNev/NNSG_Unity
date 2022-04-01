using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NNSG.Jobs;
using TMPro;

public class UISlider : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI SliderLabel;
    public TextMeshProUGUI SliderValue;
    private Job _job;

    public void Configure(Job job, string jobName)
    {
        _job = job;
        slider.value =  _job.quantityPerTick;
        SliderLabel.text = jobName;
        SliderValue.text = slider.value.ToString();

        //get the slider component
        slider = GetComponentInChildren<Slider>();

        //Bind slider to farmer quantitypertick
        slider.onValueChanged.AddListener(delegate { _job.quantityPerTick = (int)slider.value; SliderValue.text = slider.value.ToString(); });        
    }

}