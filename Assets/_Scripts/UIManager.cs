using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using NNSG.Jobs;

public class UIManager : MonoBehaviour
{
    public ResourceDisplayer _resourceDisplayer;
    public JobUI _jobUI;
    private ValueUI _population;
    private ValueUI _happiness;

    private void Start()
    {
        if (!_resourceDisplayer)
        {
            _resourceDisplayer = FindObjectOfType<ResourceDisplayer>();
        }

        if (!_population) _population = transform.Find("Population").GetComponent<ValueUI>();
        if (!_happiness) _happiness = transform.Find("GlobalHappiness").GetComponent<ValueUI>();
    }

    public void Ticking()
    {
        _resourceDisplayer.RefreshResources();
        _jobUI.RefreshValues();
        _happiness.UpdateValue(NNSG.Person.GetGlobalHappiness());
        _population.UpdateValue(NNSG.Person.people.Count);
    }
}
