# РЕШЕНИЕ ЗАДАЧИ

## Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3 символам.
____
____


`Описание решения:`
1. Выполняем первый массив строк;
2. Определяем сколько строк в первом массиве, **`<=3`** символам;
3. Зная длину второго массива, помещаем в него все строки (длина строки должна быть **`<=3`**);
4. Массив поэтапно присваивает строки, отобранные по условию, элементам второго массива и выводит индекс элемента;
5. Печатаем второй массив строк (согласно индекса элемента).

  
### `Задача (код С#)`
```C#
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
```
___

### **`БЛОК-СХЕМА`**
*формат:* 
+ drawio [here](block%20diagram.drawio)
+ png [here](Block%20diagram.png)

  ![](Block%20diagram.png)












