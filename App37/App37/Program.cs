int[] array = new int[3];

//値を設定する
array[0] = 1;
array[1] = 2;
array[2] = 3;

for (int index = 0; index < array.Length; index++)
{
    //配列から値を取り出してコンソールに表示する
    int value = array[index];
    Console.WriteLine(value.ToString());
}