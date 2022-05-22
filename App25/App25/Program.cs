Console.WriteLine("数値を入力してください。");
string input = Console.ReadLine();

int inputNumber;
bool canConvert = int.TryParse(input, out inputNumber);
if (canConvert == false)
{
    // 入力値が数値でない場合は終了する
    Console.WriteLine("正しくないため終了します。");
}
else
{
    //数値を2で割った余りが0の場合は偶数である
    if (inputNumber % 2 == 0)
    {
        Console.WriteLine("入力値は偶数です。");
    }
    else
    {
        Console.WriteLine("入力値は偶数ではありません。");
    }
}