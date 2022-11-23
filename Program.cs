Console.Write("How many money did you put in ? ");
double ORIGINAL_CREDIT = double.Parse(Console.ReadLine()!);
double CREDIT = ORIGINAL_CREDIT;
double PRICE_CAPPUCCINO = 3.5;
double PRICE_TEA = 1.5;
double PRICE_KAKAO = 2.5;
int PRODUCT = 0;
double REST_MONEY = 0;
double TWO_EURO_COINS = 0;
double ONE_EURO_COINS = 0;
double FIFTY_CENT_COINS = 0;

while (PRODUCT != 4)
{
    Console.Write("What do you want ? 1. Cappuccino, 2. Tea, 3. Kakao, 4. Nothing else ");
    PRODUCT = PRODUCT + (int.Parse(Console.ReadLine()!));
    if (PRODUCT == 1 && CREDIT >= 3.5)
    {
        CREDIT = CREDIT - PRICE_CAPPUCCINO;
    }
    else if (PRODUCT == 2 && CREDIT >= 1.5)
    {
        CREDIT = CREDIT - PRICE_TEA;
    }
    else if (PRODUCT == 3 && CREDIT >= 2.5)
    {
        CREDIT = CREDIT - PRICE_KAKAO;
    }
    else if (PRODUCT == 4)
    {
        PRODUCT = 4;
    }
    else
    {
        System.Console.WriteLine("Sorry you have not enough credit. ");
        PRODUCT = 4;
    }

}
REST_MONEY = ORIGINAL_CREDIT - CREDIT;
System.Console.WriteLine($"You have {REST_MONEY}€ left");

TWO_EURO_COINS = Math.Round(REST_MONEY / 2);
REST_MONEY = REST_MONEY - (TWO_EURO_COINS * 2);

ONE_EURO_COINS = Math.Round(REST_MONEY / 1);
REST_MONEY = REST_MONEY - (ONE_EURO_COINS * 1);

FIFTY_CENT_COINS = Math.Round(REST_MONEY / 0, 5);

System.Console.WriteLine($"you get {TWO_EURO_COINS} two euro coins,{ONE_EURO_COINS} one euro coins and {FIFTY_CENT_COINS} fifty cent coins back, ");


