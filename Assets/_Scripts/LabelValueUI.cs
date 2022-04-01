using UnityEngine;
using TMPro;

public abstract class LabelValueUI : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI _label;

    [SerializeField]
    protected TextMeshProUGUI _value;

    public abstract void Configure();

    public abstract void UpdateValue();
}
