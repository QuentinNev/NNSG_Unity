using NNSG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    public static void Trigger()
    {
        Vector3 spawnLocation = new Vector3(90, 0, 197);
        GameObject fire = Instantiate(GameManager.GetInstance().incendie, spawnLocation, Quaternion.identity) as GameObject;
    }

    private static ElapsedEventHandler DestroyFire(GameObject gameObject)
    {
        //Destroy(gameObject);
        Debug.Log("Fire destroyed");
        return null;
    }


}
