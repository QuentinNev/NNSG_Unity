using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NNSG;
using NNSG.Goods;

public class ResourceDisplayer : MonoBehaviour
{
    List<Good> goods = new List<Good>();
    [SerializeField]
    private ResourceUI _resourceTemplate;

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
                ResourceUI resource = Instantiate(_resourceTemplate);
                resource.Configure(g.GetType().ToString(), g.amount);
            }
        }

        _resourceTemplate.gameObject.SetActive(false);
    }
}