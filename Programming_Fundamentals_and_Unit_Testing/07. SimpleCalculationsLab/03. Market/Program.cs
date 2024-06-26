double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice =  double.Parse(Console.ReadLine());
double cucumberQuantity =  double.Parse(Console.ReadLine());

double tomatoCosts = tomatoQuantity * tomatoPrice;
double cucumberCosts = cucumberQuantity * cucumberPrice;

double tottalCosts = tomatoCosts + cucumberCosts;

Console.WriteLine($"{tottalCosts:f2}");