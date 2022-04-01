using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollide : MonoBehaviour
{
    //trigger that destroys the meteor when it collides with the player
    private void OnTriggerEnter(Collider collision)
    {
        if (collision is TerrainCollider)
        {
            
            Destroy(gameObject);
        }
    }

    public static void SpawnMeteor()
    {
        //spawns a meteor at a random location
        Vector3 spawnLocation = new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100));
        GameObject meteor = Instantiate(Resources.Load("Meteor"), spawnLocation, Quaternion.identity) as GameObject;
    }
}