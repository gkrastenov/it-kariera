using PreparationForExam3.Products;
using ShoppingSystem;
using System;
using System.Collections.Generic;
using System.Text;

public class Controller
{
    private ICollection<Product> _products;
    private ICollection<Receipt> _receipts;

    public Controller()
    {
        _products = new List<Product>();
        _receipts = new List<Receipt>();
    }

    public string ProcessProductCommand(List<string> args)
    {
        string name = args[0];
        double price = double.Parse(args[1]);
        double weigth = double.Parse(args[2]);

        PhysicalProduct physicalProduct = new PhysicalProduct(name, price, weigth);
        _products.Add(physicalProduct);

        return $"The current customer has bought {name}.";
    }

    public string ProcessServiceCommand(List<string> args)
    {
        string name = args[0];
        double price = double.Parse(args[1]);
        double time = double.Parse(args[2]);

        ServiceProduct serviceProduct = new ServiceProduct(name, price, time);
        _products.Add(serviceProduct);

        return $"The current customer has applied for {name} service.";
    }

    public string ProcessCheckoutCommand(List<string> args)
    {
        string customerName = args[0];
        var receipt = new Receipt(customerName);

        double sumOfProductPrices = 0;
        foreach (var currentProduct in _products)
        {
            receipt.AddProduct(currentProduct);
            sumOfProductPrices += currentProduct.Price;
        }
        _receipts.Add(receipt);
        _products.Clear();
        return $"Customer checked out for a total of ${sumOfProductPrices}.";
    }

    public string ProcessInfoCommand(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        string info = args[0];
        if(info == "Customer")
        {
            sb.AppendLine("Current customer has:");
            sb.AppendLine($"Products: {_products.Count}");
            sb.AppendLine($"Total Bill: ${_products.Sum(p => p.Price)}");
        }

        if (info == "Shop")
        {
            if (_receipts.Count == 0)
                return "Receipts: No receipts";

            sb.AppendLine("Receipts:");
            foreach (var currentReceipt in _receipts)
                sb.Append(currentReceipt.ToString());         
        }
        return sb.ToString();
    }

    public string ProcessEndCommand()
    {
        return $"Total customers today: {_receipts.Count}";
    }
}
