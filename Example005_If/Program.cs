Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "alexey")
{
    Console.WriteLine("Ура это же Alexey"); 
}
else
{
    Console.WriteLine("Хаю хай, " + username);
}