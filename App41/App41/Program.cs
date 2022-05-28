List<int> storage = new List<int>();
while (true)
{
    Console.WriteLine("数値を入力してください。");
    string input = Console.ReadLine();
    int number;
    if (int.TryParse(input, out number))
    {
        //数値に変換できたらリストに追加する
        storage.Add(number);
    }

    //3つ格納出来たらループから抜ける
    if (storage.Count == 3)
    {
        break;
    }
}

//合計値を算出してコンソールに表示する
int total = 0;
for (int index = 0; index < storage.Count; index++)
{
    total = total + storage[index];
}
Console.Write("合計値：");
Console.WriteLine(total.ToString());