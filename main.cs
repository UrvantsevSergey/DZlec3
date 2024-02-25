using System;

class Program {
  public static void Main (string[] args) 
  {
    
    Console.Write("Введите число элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] mas = new int[n];
// создали массив с вводом количества элементов пользователем
    
    void FillArray(int[] mas)
    {
      int i = 0;
      while (i < mas.Length)
      {
        Console.WriteLine("Введите элемент массива: ");
        int input = Convert.ToInt32(Console.ReadLine());
        mas[i] = input;
  
        i++;
      }
    }
    FillArray(mas);
    
// создали функцию заполнения массива числами вводом пользователем
    
    void PrintArray(int[] mas)
    {
      foreach (int item in mas)
      {
        Console.Write($"{item} ");
      }
    }
    PrintArray(mas);
// создали функцию вывода массива на экран
    void GetSumOfElemets (int[] mas)
    {
      int sum = 0;
      int i = 0;
      while (i < mas.Length)
      {
        sum = sum + mas[i];
        i++;
      }
      Console.WriteLine($"Сумма элементов массива: {sum}");
    }
    GetSumOfElemets(mas);
// создали функцию нахождения суммы элементов массива
Console.WriteLine();
    void GetProductOfElements (int[] mas)
    {
      int product =1;
      for (int i = 0; i < mas.Length; i++)
      {
        product = product * mas[i];
      }
      Console.WriteLine($"Произведение элементов массива: {product}");
    }
    GetProductOfElements(mas);
// создали функцию нахождения произведения элементов массива
  }
}