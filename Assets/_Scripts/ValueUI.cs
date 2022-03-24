using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueUI : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI _textValue;

    public void UpdateValue(int value)
    {
        _textValue.SetText(value.ToString());
    }
}
