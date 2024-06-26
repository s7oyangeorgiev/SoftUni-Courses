// Read the number of products
int n = int.Parse(Console.ReadLine());

// Create a list to store the products
List<string> products = new List<string>();

// Read n lines of products
for (int i = 0; i < n; i++)
{
    products.Add(Console.ReadLine());
}

// Sort the products by name
products.Sort();

// Print the numbered list of products
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}