Console.WriteLine("Введите имя пользователя: ");
string username=Console.ReadLine(); // считываем имя пользователя

if(username.ToLower()=="маша")
{
    Console.WriteLine("Ура, это же Машенька!!! :) ");
}
else
{
Console.Write("Приветик, ");
Console.WriteLine(username);
}