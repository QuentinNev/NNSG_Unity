using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeFlow : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _value;

    [SerializeField]
    private Slider _slider;

    private void Start()
    {
        _slider.onValueChanged.AddListener(delegate
        {
            _value.SetText(_slider.value.ToString());
            TimeManager._timeFactor = _slider.value;
        });
    }
}
