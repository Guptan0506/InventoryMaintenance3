namespace InventoryMaintenance
{
    public class InventoryItem
    {
        public InventoryItem() { }

        // Navya Gupta

        public InventoryItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        // Navya Gupta

        public int ItemNo { get; set; }
        public string Description { get; set; } = "";
        public decimal Price { get; set; }

        // Navya Gupta

        public string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
