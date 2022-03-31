using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NNSG.Jobs;
using NNSG;

public class UISliders : MonoBehaviour
{
    [SerializeField]
    private UISlider _slider;
    [SerializeField]
    private Transform scrollView;
    private List<Job> _allJobs = new List<Job>();

    public void Start()
    {
        _allJobs.Add(Tailor.GetInstance());
        _allJobs.Add(Artisan.GetInstance());
        _allJobs.Add(Farmer.GetInstance());
        _allJobs.Add(Mechanic.GetInstance());


        foreach (Job job in _allJobs)
        {
            UISlider slider = Instantiate(_slider, scrollView);
            slider.Configure(job);
        }
    }
}
