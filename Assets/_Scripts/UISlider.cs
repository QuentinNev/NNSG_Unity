using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NNSG.Jobs;

public class UISlider : MonoBehaviour
{
    public Slider slider;
    private Job _job;

    public void Configure(Job job)
    {
        _job = job;
        //get the slider component
        slider = GetComponent<Slider>();

        //Bind slider to farmer quantitypertick
        slider.onValueChanged.AddListener(delegate { _job.quantityPerTick = (int)slider.value; });        
    }

}