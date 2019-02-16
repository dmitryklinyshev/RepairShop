using AbstractRepairShopServiceDAL.BindingModel;
using AbstractRepairShopServiceDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractRepairShopServiceDAL.Interfaces
{
    public interface MainInterface
    {
        List<OrderViewModel> GetList();
        void CreateOrder(OrderBindingModel model);
        void TakeOrderInWork(OrderBindingModel model);
        void FinishOrder(OrderBindingModel model);
        void PayOrder(OrderBindingModel model);
    }
}
