
    
      // Ввод массив строк с клавиатуры ,
      // выборка из них элементов, длина которых не превышает 3-х символов

      // Объявление переменных
      string[] inputArray; // вводимый массив строк
      string str; // вводимая строка с клавиатуры 
      string[] outArray; // выводимый массив строк

      //  Цикл ввода строк
      int numberOfLines;
      Console.WriteLine("Введите количество строк массива:");
      numberOfLines = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Введите массив строк:");
      int countInput = 0, countOutput=0; // обнулить количество строк
      inputArray = new string[numberOfLines]; // выделить память для вводимого массива строк
      outArray = new string[numberOfLines]; // выделить память для выводимого массива строк

      do
      {
        // Ввести строку
        str = Console.ReadLine();

        // Проверка, пустая ли строка
        if (str!="")
        {
          inputArray[countInput] = str;
          countInput++;
          if (str.Length <= 3)  {
              outArray[countOutput]=str;
              countOutput++;
          }         
        }
        
      } while (str != "" & countInput < numberOfLines );
      //Контроль наличие пустого вводимого файла
      if (countInput==0){
        Console.WriteLine("Вводимый файл пуст");
        return;
      }
      //  Вывод массивов строк  в цикле
      Console.WriteLine("Введенный массив:{0} строк",countInput );
      for (int i = 0; i < countInput; i++){
        Console.WriteLine("inputArray[{0}] = {1}", i, inputArray[i]);
      Console.ReadKey(); }
      //Контроль наличие пустого выводимого файла
      if (countOutput==0){
        Console.WriteLine("Выводимый  массив пуст. Длина всех элементов массива превышает 3");
        return;
      }
      Console.WriteLine("Выводимый массив:{0} строк",countOutput );
      for (int i = 0; i < countOutput; i++)
      {
        Console.WriteLine("outArray[{0}] = {1}", i, outArray[i]);
        Console.ReadKey();
      }
    
  

