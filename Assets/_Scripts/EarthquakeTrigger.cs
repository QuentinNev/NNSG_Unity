using NNSG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeTrigger : MonoBehaviour
{
    private static bool isTriggered = false;
    private float timer = 0;
    public void Update()
    {
        if (isTriggered)
        {
            GameManager.GetInstance().terrain.transform.position = new Vector3(Mathf.Sin(UnityEngine.Time.time * 50f) * 0.2f, 0f);
            timer += UnityEngine.Time.deltaTime;
        }
        if (timer >= 2)
        {
            timer = 0;
            isTriggered = false;
        }

    }
    public static void TriggerEarthquake()
    {
        isTriggered = true;
        
    }
}
