int basketballTrainingFee = int.Parse(Console.ReadLine());

int trainingPerYearCosts = basketballTrainingFee;
double basketballSneakersCosts = trainingPerYearCosts * 0.60;
double basketballUniformCosts = basketballSneakersCosts * 0.80;
double basketballBallCosts = basketballUniformCosts * 0.25;
double basketballAccessoriesCosts = basketballBallCosts * 0.20;
double totalPrice = trainingPerYearCosts + basketballSneakersCosts + basketballUniformCosts +
    basketballBallCosts + basketballAccessoriesCosts;

Console.WriteLine(totalPrice);