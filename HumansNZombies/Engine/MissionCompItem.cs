using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class MissionCompItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public MissionCompItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
