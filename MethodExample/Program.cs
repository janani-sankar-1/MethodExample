class Sample
{
    static void Main()
    {
        //local constant
        const string developerName = "Janani";

        //reference variable
        Product p1, p2, p3;

        //create objects
        p1 = new Product();
        Product.TotalNoProducts++;
        p2 = new Product();
        Product.TotalNoProducts++;
        p3 = new Product();
        Product.TotalNoProducts++;

        //Initialize fields
        p1.productID = 1001;
        p1.productName = "Mobile";
        p1.cost = 20000;
        p1.quantityInStock = 1200;

        p2.productID = 1002;
        p2.productName = "Laptop";
        p2.cost = 30000;
        p2.quantityInStock = 800;

        p3.productID = 1003;
        p3.productName = "Speakers";
        p3.cost = 2000;
        p3.quantityInStock = 500;

        p1.CalculateTax();
        p2.CalculateTax();
        p3.CalculateTax();

        System.Console.WriteLine(developerName);
        //get values from fields
        System.Console.WriteLine("ProductID : " + p1.productID);
        System.Console.WriteLine("ProductName : " + p1.productName);
        System.Console.WriteLine("cost : " + p1.cost);
        System.Console.WriteLine("quantity : " + p1.quantityInStock);
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p1.tax);
        System.Console.WriteLine();

        System.Console.WriteLine("ProductID : " + p2.productID);
        System.Console.WriteLine("ProductName : " + p2.productName);
        System.Console.WriteLine("cost : " + p2.cost);
        System.Console.WriteLine("quantity : " + p2.quantityInStock);
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p2.tax);
        System.Console.WriteLine();

        System.Console.WriteLine("ProductID : " + p3.productID);
        System.Console.WriteLine("ProductName : " + p3.productName);
        System.Console.WriteLine("cost : " + p3.cost);
        System.Console.WriteLine("quantity : " + p3.quantityInStock);
        System.Console.WriteLine("Date Of Purchase : " + p1.dateOfPurchase);
        System.Console.WriteLine("Tax : " + p3.tax);
        System.Console.WriteLine();

        System.Console.WriteLine("Total product : " + Product.TotalNoProducts);
        System.Console.WriteLine("Category Name : " + Product.CategoryName);

        System.Console.ReadKey();

    }
}

