namespace AbstractRepairShop.BindingModel
{
    public class WorkTypeMaterialBindingModel
    {
        public int Id { get; set; }
        public int WorkTypeId { get; set; }
        public int MaterialId { get; set; }
        public int Count { get; set; }
    }
}
}