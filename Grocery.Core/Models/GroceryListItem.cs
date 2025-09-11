namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        // Member variabelen veranderd naar properties
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        // Constructor koppelt de doorgegeven waarden aan de properties
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}

