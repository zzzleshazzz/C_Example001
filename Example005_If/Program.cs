Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "Alexey")
{
    Console.WriteLine("Ура это же Леха"); 
}
else
{
    Console.WriteLine("Хаю хай, " + username);
}