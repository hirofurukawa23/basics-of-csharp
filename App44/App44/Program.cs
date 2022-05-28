for (int index = 1; index <= 100; index++)
{
    string output = "";
    if (index % 15 == 0)
    {
        output = "FizzBuzz";
    }
    else if (index % 5 == 0)
    {
        output = "Buzz";
    }
    else if (index % 3 == 0)
    {
        output = "Fizz";
    }
    else
    {
        output = index.ToString();
    }
    Console.WriteLine(output);
}