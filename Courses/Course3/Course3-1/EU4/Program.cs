Random coin = new Random();

int coinflip = coin.Next(0, 2);

Console.WriteLine($"{(coinflip == 1 ? "heads" : "tails")}");