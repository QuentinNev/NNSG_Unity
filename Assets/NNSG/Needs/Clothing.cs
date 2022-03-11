using System;
using UnityEngine;

namespace NNSG.Needs
{
    class Clothing : Need
    {
        public Clothing(int value)
        {
            level = value;
        }

        public override void Consume()
        {
            if (Warehouse.clothes.amount > 0 && Randomizer.Probability(100 - level))
            {
                Warehouse.clothes.amount--;
                level = 100;
            }
            else
            {
                level = Mathf.Clamp(level -= Randomizer.Range(1, 15), 0, 100);
            }
        }
    }
}
