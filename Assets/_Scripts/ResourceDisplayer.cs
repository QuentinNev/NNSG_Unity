using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NNSG;
using NNSG.Goods;

public class ResourceDisplayer : MonoBehaviour
{
    List<Good> goods = new List<Good>();
    [SerializeField]
    private GoodUI _goodTemplate;

    private void Start()
    {
        // Get all goods
        goods.Add(Warehouse.food);
        goods.Add(Warehouse.furniture);
        goods.Add(Warehouse.clothes);
        goods.Add(Warehouse.vehicles);

        // Check if Warehouse was correctly initialized
        if (goods.Count > 0 && goods[0] != null)
        {
            foreach (Good g in goods)
            {
                GoodUI resource = Instantiate(_goodTemplate, transform);
                resource.Configure(g.GetType().ToString(), g.amount);
            }
        }
        else
        {
            Debug.LogError("Couldn't find any Good, make sure GameManager is running");
        }

        _goodTemplate.gameObject.SetActive(false);
    }
}