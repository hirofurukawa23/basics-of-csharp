for (int tate = 1; tate <= 9; tate++)
{
    for (int yoko = 1; yoko <= 9; yoko++)
    {
        int total = tate * yoko;
        //数字と数字の間隔用のスペース
        string output = " ";
        //出力文字を整形する -> 9：" 9" / 10："10"
        if (total < 10)
        {
            output += " ";
        }
        output += total.ToString();
        Console.Write(output);
    }
    Console.WriteLine();
}
