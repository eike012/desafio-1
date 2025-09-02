public class Product
{
   public int Id { get; private set; }
   public string Name { get; private set; }
   public string Description { get; private set; }
   public float Price { get; private set; }
   public string Category { get; private set; }
   public int Quantity { get; private set; }

   public Product(string name, string description, string category, float price, int quantity)
   {
      if (string.IsNullOrWhiteSpace(name))
         throw new ArgumentException("Name cannot be empty");
      if (price < 0)
         throw new ArgumentException("Price cannot be negative");
      if (quantity < 0)
         throw new ArgumentException("Quantity cannot be negative");


      Name = name;
      Description = description;
      Category = category;
   }
      public void UpdateQuantity(int amount)
      {
        if (amount < 0) 
            throw new ArgumentException("Quantity cannot be negative");
        Quantity = amount;
      }

    public void UpdatePrice(float newPrice)
    {
      if (newPrice < 0)
          throw new ArgumentException("Price cannot be negative");
      Price = newPrice;
    }

}