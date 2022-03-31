using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    public abstract class Job : ITick
    {        
        /// <summary>
        /// How much resource is produced each tick
        /// </summary>
        public int quantityPerTick = 2;
        public abstract void Ticking();
    }
}