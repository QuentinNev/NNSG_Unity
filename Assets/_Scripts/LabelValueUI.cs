using UnityEngine;
using TMPro;

public abstract class LabelValueUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _label;

    [SerializeField]
    private TextMeshProUGUI _value;

    public abstract void Configure();

    public abstract void UpdateValue();
}
