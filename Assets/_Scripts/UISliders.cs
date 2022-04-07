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
    public Button openSliders;

    public void Start()
    {
        gameObject.SetActive(false);
        openSliders.onClick.AddListener(OpenSliders);

        foreach (Job job in GameManager.GetInstance().allJobs)
        {
            UISlider slider = Instantiate(_slider, scrollView);
            slider.Configure(job, job.GetType().Name);
        }
    }

    void OpenSliders()
    {
        //change visibility of this object
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
