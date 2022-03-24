using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    ResourceDisplayer _resourceDisplayer;
    [SerializeField]
    private ValueUI _population;
    [SerializeField]
    private ValueUI _happiness;

    private void Start()
    {
        
        if (!_resourceDisplayer)
            _resourceDisplayer = FindObjectOfType<ResourceDisplayer>();
    }

    public void Ticking()
    {
        _resourceDisplayer.RefreshResources();
        _happiness.UpdateValue(NNSG.Person.GetGlobalHappiness());
        _population.UpdateValue(NNSG.Person.people.Count);
    }
}
