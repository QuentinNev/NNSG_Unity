using UnityEngine;
using TMPro;

public class GoodUI : LabelValueUI
{
    
    [SerializeField]
    private NNSG.Goods.Good _good { get; set; }
    
    [SerializeField]
    private TextMeshProUGUI _label;

    [SerializeField]
    private TextMeshProUGUI _value;

    public override void Configure(){}

    public void Configure(NNSG.Goods.Good good)
    {
        this._good = good;
        UpdateValue();
        _label.SetText(this._good.GetType().Name);
    }

    public override void UpdateValue()
    {
        _value.SetText(_good.amount.ToString());
    }
}
