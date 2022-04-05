// Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3 символам. 
// (Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении лучше обойтись массивами).

string[] frstArry = {"program", "123", "bin", "final", "obj", "run", "p", "2", "ok"};
string[] scndArry;
int count = 0;
int length = 0;

    foreach (string elmnt in frstArry)
        {
        if (elmnt.Length <= 3)
        length++;
        }
    scndArry = new string[length];
        for (int j = 0; j < frstArry.Length; j++)
            {
            if (frstArry[j].Length <= 3)
                {
                scndArry[count] = frstArry[j];
                Console.Write($"\t{count} ");
                count++;   
                }
            }
    Console.WriteLine();
    foreach (string elmnt in scndArry)
    {
    Console.Write($"\t{elmnt} ");
    }
    Console.ReadLine();