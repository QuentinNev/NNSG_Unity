using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NNSG;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    ResourceDisplayer _resourceDisplayer;
    private NNSG.Time _time;

    /// <summary>
    /// Used to track elapsed time in order to trigger ticks
    /// </summary>
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        _time = NNSG.Time.GetInstance();

        if (_time == null)
            Debug.LogError("Couldn't get instance of NNSG.Time but it's impossible because it's a singleton");
        else
        {
            _timer = _time.tickInterval;
        }

        if (!_resourceDisplayer)
            _resourceDisplayer = FindObjectOfType<ResourceDisplayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer <= 0)
        {
            _timer = _time.tickInterval;
            _time.TickAll();
            _resourceDisplayer.RefreshResources();
        }
        else
        {
            _timer -= UnityEngine.Time.deltaTime;
        }
    }
}
