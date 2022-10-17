/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 999);
}

int EvenArray(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if((array[i]%2)==0)
count++; 
}
return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($" Массив: [{string.Join(", ", array)}]");
Console.Write(EvenArray(array));
*/


/*
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-10, 10);
}
void sumArray(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
        sum += array[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
sumArray(array);

*/

/*
double[] myarray = {3.2 , 6.4 , 8.8 , 3.1 , 4.2, 10.2 ,5.4} ;
double minnum=myarray[0];
for (int i=1;i<myarray.Length;i++)

{
 if( myarray[i]<minnum)
minnum=myarray[i];

 }
Console.WriteLine(minnum +" минимальное число "  );

double maxnum=myarray[0];
for (int i=1;i<myarray.Length;i++)

{
 if( myarray[i]>maxnum)
maxnum=myarray[i];

 }
Console.WriteLine(maxnum +" максимальное число "  );

*/
