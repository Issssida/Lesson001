Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "ильсина")
{
       Console.WriteLine("Ура, это же Ильсина!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}