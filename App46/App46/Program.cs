for (int tate = 1; tate <= 12; tate++)
{
    for (int yoko = 1; yoko <= 12; yoko++)
    {
        int total = tate * yoko;
        string output = " "; //間隔用スペース
        if (total < 10)
        {
            //1桁なら2桁埋めて3桁
            output += "  ";
        }
        if (10 <= total && total < 100)
        {
            //2桁なら1桁埋めて3桁
            output += " ";
        }
        output += total.ToString(); //計算結果を設定
        Console.Write(output);
    }
    Console.WriteLine();
}