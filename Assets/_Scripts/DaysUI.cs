using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaysUI : ValueUI
{
    public override void UpdateValue(int value)
    {
        _textValue.SetText(value.ToString());
    }
}
