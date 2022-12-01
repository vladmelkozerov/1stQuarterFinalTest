// //Итоговая проверочная работа за первую четверть
string [] array1=new string[5];
string [] array2=new string[5];
int j=0;
for (int i=0;i<array1.Length;i++)
    {   
        Console.WriteLine($"Введите {i+1}-й элемент массива строк");
        array1[i]=Console.ReadLine()!;
        if (array1[i].Length<=3)      
            {
                array2[j]=array1[i];
                j++;
            }
    }