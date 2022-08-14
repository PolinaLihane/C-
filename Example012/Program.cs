// Вид 1

void Method1()
{
    Console.WriteLine("Автор");// например на каждой странице печатаем имя автора
}
//Method1();

//Вид 2
void Method2(string msg)
{
 Console.WriteLine(msg);
}
//Method2(msg: "Текст");

void Method21(string msg,int count)
{
    int i =0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст",4);

//Метод 3

int Method3()
{
    return DateTime.Now.Year;
}
//int year= Method3();
//Console.WriteLine(year);

//Вид4

string Method4(int count, string c)
{
 string result = String.Empty;

 for(int i=0;i<count;i++)
 {
    result = result + c;
 }
 return result;
}

//string res = Method4(10,"c");
//Console.WriteLine(res);

//таблица умножения

//for (int i=2;i<=10;i++)
//{
//    for (int j=2;j<10;j++)
 //   {
  //      Console.WriteLine($"{i}*{j}={i*j}");
 //   }
 //   Console.WriteLine();
//}

// Задача. Зменить к на К,С на с

string text = "-Я думаю, - сказал князь, улыбаясь, -что,"
            + "ежели бы Вас послаливместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s ="qwert"
 //          01234  
 // s[3] //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0; i<length; i++)
    {
      if(text[i] == oldValue) result = result +$"{newValue}"; //если совпадает с поиском то меняем
      else result =result + $"{text[i]}";//иначе добавляем текущий символ 
    }
    return result;
}     
//string newText = Replace(text,' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//string newText = Replace(text,'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
//string newText = Replace(text,'С', 'с');
//Console.WriteLine(newText);

//Упорядочить массив

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i =0;i<array.Length -1 ;i++)// что бы следующий не был конечным
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j] < array[minPosition])
            minPosition =j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);