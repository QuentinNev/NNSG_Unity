using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceUI : MonoBehaviour
{
    public NNSG.Goods.Good good { get; set; }
    
    [SerializeField]
    private TextMeshProUGUI _label;

    [SerializeField]
    private TextMeshProUGUI _value;

    public void UpdateValue(float value)
    {
        _value.SetText(value.ToString());
    }
}
