using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodUI : MonoBehaviour
{
    public NNSG.Goods.Good good { get; set; }
    
    [SerializeField]
    private TextMeshProUGUI _label;

    [SerializeField]
    private TextMeshProUGUI _value;

    public void Configure(string label, float value)
    {
        _label.SetText(label);
        _value.SetText(value.ToString());
    }

    public void UpdateValue(float value)
    {
        _value.SetText(value.ToString());
    }
}
