Console.WriteLine("１つ目の数値を入力してください。");
string input1 = Console.ReadLine();
int convertNum1;
bool canConvert1 = int.TryParse(input1, out convertNum1);

Console.WriteLine("２つ目の数値を入力してください。");
string input2 = Console.ReadLine();
int convertNum2;
bool canConvert2 = int.TryParse(input2, out convertNum2);

//1つ目の入力値が変換されていたら、2つ目の入力値を確認する
if (canConvert1 == true)
{
    if(canConvert2 == true)
    {
        //2つの入力値がともに変換されているなら合計を表示
        int total = convertNum1 + convertNum2;
        Console.Write("入力値の合計は ");
        Console.Write(total.ToString());
        Console.Write(" です。");
    }
    else
    {
        //2つ目が変換できなかった場合のメッセージ表示
        Console.WriteLine("正しくないため終了します。");
    }
}
else
{
    //１つ目が変換できなかった場合のメッセージ表示
    Console.WriteLine("正しくないため終了します。");
}