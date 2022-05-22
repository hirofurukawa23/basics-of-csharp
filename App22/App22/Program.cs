Console.WriteLine("数値を入力してください。");
string input = Console.ReadLine();

int converted;
bool isParsed = int.TryParse(input, out converted);
if (isParsed == false)
{
    Console.WriteLine("正しくないため終了します。");
}
else
{
    Console.Write("入力した数値：");
    Console.Write(converted.ToString());
}