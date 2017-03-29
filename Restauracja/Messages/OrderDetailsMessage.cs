using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restauracja.Model;

namespace Restauracja.Messages
{
    public class OrderDetailsMessage
    {
        public List<DishModel> Positions = new List<DishModel>();
        public double Cost = 0;
    }
}

