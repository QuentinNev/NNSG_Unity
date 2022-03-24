using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using NNSG;
using NNSG.Goods;

public class ResourceDisplayer : MonoBehaviour
{
    List<Good> goods = new List<Good>();
    [SerializeField]
    private GoodUI _goodTemplate;
    [SerializeField]
    private Transform _container;
    private List<GoodUI> _goodUIs = new List<GoodUI>();

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
                GoodUI resource = Instantiate(_goodTemplate, _container);
                resource.Configure(g);
                _goodUIs.Add(resource);
            }
        }
        else
        {
            Debug.LogError("Couldn't find any Good, make sure GameManager is running");
        }

        //_goodTemplate.gameObject.SetActive(false);
    }

    public void RefreshResources()
    {
        _goodUIs.ForEach(good => good.UpdateValue());
    }
}