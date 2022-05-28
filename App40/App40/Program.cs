List<string> list = new List<string>();
for (int index = 0; index < 3; index++)
{
    Console.WriteLine("何か入力してください。");
    var input = Console.ReadLine();
    list.Add(input);
}

Console.WriteLine("出力します。");
for (int index = 0; index < list.Count; index++)
{
    Console.WriteLine(list[index]);
}