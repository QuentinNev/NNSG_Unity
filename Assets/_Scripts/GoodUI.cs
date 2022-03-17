using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodUI : MonoBehaviour
{
    private NNSG.Goods.Good _good { get; set; }
    
    [SerializeField]
    private TextMeshProUGUI _label;

    [SerializeField]
    private TextMeshProUGUI _value;

    public void Configure(NNSG.Goods.Good good)
    {
        this._good = good;
        UpdateValue();
        _label.SetText(this._good.GetType().Name);
    }

    public void UpdateValue()
    {
        _value.SetText(_good.amount.ToString());
    }
}
