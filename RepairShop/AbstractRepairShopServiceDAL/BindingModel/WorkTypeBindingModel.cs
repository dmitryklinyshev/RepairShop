using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRepairShop.BindingModel
{
   public class WorkTypeBindingModel
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public List<WorkTypeMaterialBindingModel> WorkTypeMaterial { get; set; }
    }
}
