using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueUI : MonoBehaviour
{
    [SerializeField]
    protected TMPro.TextMeshProUGUI _textValue;

    public virtual void UpdateValue(int value)
    {
        _textValue.SetText(value.ToString());
    }
}
