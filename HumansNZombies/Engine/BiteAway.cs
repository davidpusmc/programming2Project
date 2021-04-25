using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
   public class BiteAway : Item
    {

        public int AmountToHeal { get; set; }

        public BiteAway(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)//because inherits from Item in order to use constructor we must give it inheritance from base constructor
        {
            AmountToHeal = amountToHeal;
        }
    }
}
