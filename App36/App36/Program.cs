while (true)
{
    Console.WriteLine("何か入力してください。");
    string input = Console.ReadLine();
    int convert;
    if (int.TryParse(input, out convert))
    {
        if (convert < 0)
        {
            Console.WriteLine("終了します。");
            break;
        }
    }
}