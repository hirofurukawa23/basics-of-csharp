int totalAmount = 5100;
if (totalAmount >= 5000)
{
    Console.WriteLine("500円割引の対象です。");
    totalAmount = totalAmount - 500;
}

Console.Write("合計金額：");
Console.Write(totalAmount.ToString());
Console.Write("円");