public class Product
{
    public string Name;
    public int Quantity;

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

   public void Restock(int amount)
    {
        if (amount <= 0)
        {
            return;       
        }
        Quantity += amount;
    }
}