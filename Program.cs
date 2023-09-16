using AccountsManagerApp.BLL;
using AccountsManagerApp.DAL;
using AccountsManagerApp.VL;

AccountsManager manager;
try
{
    manager = new AccountsManager(new JsonContext("accounts.json"));
}
catch (ArgumentNullException e)
{
    CLI.PrintError("Передан пустой путь к файлу");
    return;
}
catch (ArgumentException e)
{
    CLI.PrintError("Увзанный файл не существует");
    return;
}

var login = CLI.InputString("Введите логин: ");
var password = CLI.InputString("Введите пароль: ");

var account = manager.Auth(login, password);
if (account is null)
{
    CLI.PrintWarning("Нет такого пользователя!");
}
else
{
    CLI.PrintSuccess("Успешно авторизовались!");
}