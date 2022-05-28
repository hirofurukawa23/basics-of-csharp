string[] array = new string[3];
array[0] = "カレー";
array[1] = "寿司";
array[2] = "ラーメン";

for (int index = 0; index < array.Length; index++)
{
    string meal = array[index];
    Console.WriteLine(meal);
}