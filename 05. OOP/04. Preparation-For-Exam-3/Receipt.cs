using PreparationForExam3.Products;
using System.Text;

namespace ShoppingSystem
{
    public class Receipt
	{
        private string customerName;
        private ICollection<Product> products;

        public Receipt(string customerName)
        {
            CustomerName = customerName;
            products = new List<Product>();
        }

        public string CustomerName
        {
            get { return customerName; }
            set { CustomerNameValidation(value); }
        }

        public void AddProduct(Product product)
        {
            if(product != null)
                products.Add(product);
        }

        private void CustomerNameValidation(string customerName)
        {
            if (customerName.Length < 2 || customerName.Length > 20)
                throw new ArgumentException("Customer Name should be between 2 and 40 characters!");
            this.customerName = customerName;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Receipt of {CustomerName}");
            stringBuilder.AppendLine($"Total Price: { products.Sum(p => p.Price) }");
            stringBuilder.AppendLine($"Products:");

            foreach (var currentProduct in products)
            {
                stringBuilder.AppendLine(currentProduct.ToString());
            }
            return stringBuilder.ToString();
        }
    }

}
