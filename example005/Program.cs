Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Маша")
{
     Console.WriteLine("Ура,это же Маша! Приветствую тебя.");
}

else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}