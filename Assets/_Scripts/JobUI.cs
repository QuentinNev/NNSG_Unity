using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using NNSG.Jobs;
using NNSG;

public class JobUI : ValueUI, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    Transform _list;
    [SerializeField]
    JobElement _defaultElement;
    private List<JobElement> _elements = new List<JobElement>();
    [SerializeField]
    Transform _container;

    private void Start()
    {
        foreach(Job j in GameManager.GetInstance().allJobs)
        {
            JobElement element = Instantiate(_defaultElement, _container);
            element.Configure(j);
            _elements.Add(element);
        }
    }

    public void RefreshValues()
    {
        foreach(JobElement e in _elements)
        {
            e.UpdateValue();
        }
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _list.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        _list.gameObject.SetActive(false);
    }
}
