try
{
    string input = Console.ReadLine();
    int converted = int.Parse(input);
    Console.Write("入力した数値：");
    Console.Write(converted.ToString());
}
catch (Exception ex)
{
    Console.WriteLine("正しくないため終了します。");
}