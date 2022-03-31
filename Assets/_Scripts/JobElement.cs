using TMPro;
using UnityEngine;
using NNSG.Jobs;

public class JobElement : LabelValueUI
{
    private Job _job;
    /// <summary>
    /// DON't CALL THIS METHOD
    /// Used the overloaded version instead
    /// </summary>

    public override void Configure() { }
    public void Configure(Job job) { }

    public override void UpdateValue()
    {
        throw new System.NotImplementedException();
    }
}
