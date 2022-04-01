using TMPro;
using UnityEngine;
using NNSG.Jobs;
using NNSG;

public class JobElement : LabelValueUI
{
    private Job _job;
    /// <summary>
    /// DON't CALL THIS METHOD
    /// Used the overloaded version instead
    /// </summary>

    public override void Configure() { }
    public void Configure(Job job)
    {
        _job = job;
        _label.SetText(_job.GetType().Name);
        UpdateValue();
    }

    public override void UpdateValue()
    {
        _value.SetText(Person.people.FindAll(p => p.job != null && p.job.GetType() == _job.GetType()).Count.ToString());
    }
}
