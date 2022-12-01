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
Console.WriteLine("Элементы нового массива, включающие все элементы исходного массива с длиной не более 3 символов");
for (int l=0;l<array2.Length;l++)
    if (array2[l]!=null)
        Console.Write (array2[l]+"  ");
Console.WriteLine();
