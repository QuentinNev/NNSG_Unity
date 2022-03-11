using UnityEngine;

namespace NNSG.Needs
{
    class Hunger : Need
    {
        /// <summary>
        /// Create a new need for a person
        /// </summary>
        /// <param name="value">Base satisfaction level of this need</param>
        public Hunger(int value)
        {
            level = value;
        }

        public override void Consume()
        {
            if (Warehouse.food.amount > 0)
            {
                Warehouse.food.amount--;
                level = 100;
            }
            else
            {
                level = Mathf.Clamp(level -= Randomizer.Range(1, 15), 0, 100);
            }
        }
    }
}
