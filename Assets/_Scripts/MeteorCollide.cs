using NNSG;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollide : MonoBehaviour
{

    private static Func<bool> callback;
    //trigger that destroys the meteor when it collides with the player
    private void OnTriggerEnter(Collider collision)
    {
        if (collision is TerrainCollider)
        {
            GameObject explosion = Instantiate(GameManager.GetInstance().explosion, new Vector3(133, 0, 172), Quaternion.identity) as GameObject;
            callback();
            Destroy(gameObject);
        }
    }
    
    public static void SpawnMeteor(Func<bool>changeValue)
    {
        //spawns a meteor at a random location
        Vector3 spawnLocation = new Vector3(133, 300, 172);
        GameObject meteor = Instantiate(GameManager.GetInstance().meteor, spawnLocation, Quaternion.identity) as GameObject;
        callback = changeValue;
    }
}