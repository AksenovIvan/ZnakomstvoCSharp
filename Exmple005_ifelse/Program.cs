Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "иван")
{
    Console.WriteLine("Ура!Это же Иван, тихо-тихо");
}
else
{
Console.Write ("Привет, ");
Console.WriteLine (username);

}