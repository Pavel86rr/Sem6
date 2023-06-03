//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

 Console.WriteLine("Введите элементы через пробел ");

 int[] inputArray = Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);

 int count =0;
 int size = inputArray.Length;
 for(int i=0; i < size; i++)
   {
     if(inputArray [i]>0)
    {
        count=count + 1;
    }
   }
 Console.WriteLine(count);
