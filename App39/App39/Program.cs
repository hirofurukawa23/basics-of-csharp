List<string> list = new List<string>();
list.Add("Good morning!");
list.Add("Good afternoon!");
list.Add("Good evening!");

for (int index = 0; index < list.Count; index++)
{
    var message = list[index];
    Console.WriteLine(message);
}