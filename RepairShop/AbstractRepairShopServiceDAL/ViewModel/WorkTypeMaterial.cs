using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRepairShopServiceDAL.ViewModel
{
    public class WorkTypeMaterial
    {
        public int Id { get; set; }
        public int WorkTypeId { get; set; }
        public int MaterialId { get; set; }
        public int Count { get; set; }
    }
}
