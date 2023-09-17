Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine(); //считывание введенной информации, тип данных - строки

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}