using AbstractRepairShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRepairShopServiceImplement
{
     public class DataListSingleTon
    {
        private static DataListSingleTon instance;

        public List<Order> Orders { get; set; }
        public List<Material> Materials { get; set; }
        public List<WorkType> WorkTypes { get; set; }
        public List<WorkTypeMaterial> WorkTypeMaterials { get; set; }
        public List<Client> Clients { get; set; }

        private DataListSingleTon()
        {
            Clients = new List<Client>();
            Materials = new List<Material>();
            Orders = new List<Order>();
            WorkTypes = new List<WorkType>();
            WorkTypeMaterials = new List<WorkTypeMaterial>();
        }

        private static DataListSingleTon getInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleTon();
            }
            return instance;
        }
      
    }
}
