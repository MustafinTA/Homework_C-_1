
Console.WriteLine("Введите число 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
    Console.WriteLine("Равны"); 
else
if (num1 < num2)
    Console.WriteLine("max = {0} ", num2);
else
    Console.WriteLine("max = {0}", num1);