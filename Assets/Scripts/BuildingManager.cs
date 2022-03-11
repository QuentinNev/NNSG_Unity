using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BuildingManager : MonoBehaviour
{
    [SerializeField]
    List<Building> buildings = new List<Building>();

    void Start()
    {
        if (buildings != null || buildings.Count == 0)
        {
            Debug.LogWarning("BuildingManager has no buildings referenced. Please call GetBuildings from context menu to reduce inital loading time.");
            GetBuildings();
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Building b in buildings)
        {   Vector3 pos = b.transform.position;
            pos.y = Mathf.Lerp(b.transform.position.y, b.defaultPosition.y, Time.deltaTime );
            b.transform.position = pos;
        }
    }

    [ContextMenu("Get Buildings")]
    List<Building> GetBuildings()
    {
        return buildings = FindObjectsOfType<Building>().ToList();
    }
}
