Console.Write("введите ваше имя ");
string username1 = Console.ReadLine();

if (username1.ToLower() == "m")
{
    Console.WriteLine("Ура!Это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username1);
}
