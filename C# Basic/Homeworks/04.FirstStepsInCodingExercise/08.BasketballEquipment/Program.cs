// incorrect code

int feeForYear = int.Parse(Console.ReadLine());

double percentForShoes = feeForYear * 0.4;
double percentForClotes = percentForShoes * 0.2;

double moneyForShoes = feeForYear - percentForShoes;
double moneyForClothes = moneyForShoes - percentForClotes;
double moneyForBall = moneyForClothes * 0.25;
double moneyForАccessories = moneyForBall * 0.2;
double tottalPriceForEquipment = feeForYear + moneyForShoes + moneyForClothes + moneyForBall + moneyForАccessories;

Console.WriteLine(tottalPriceForEquipment);

// correct code

int feeForYear = int.Parse(Console.ReadLine());

double moneyForShoes = feeForYear * 0.6;
double moneyForClothes = moneyForShoes * 0.8;
double moneyForBall = moneyForClothes * 0.25;
double moneyForАccessories = moneyForBall * 0.2;
double tottalPriceForEquipment = feeForYear + moneyForShoes + moneyForClothes + moneyForBall + moneyForАccessories;

Console.WriteLine(tottalPriceForEquipment);


