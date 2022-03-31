using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JobUI : ValueUI, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    Transform _jobList;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _jobList.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        _jobList.gameObject.SetActive(false);
    }
}
