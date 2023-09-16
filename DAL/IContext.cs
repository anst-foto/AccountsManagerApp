using AccountsManagerApp.Model;

namespace AccountsManagerApp.DAL;

public interface IContext
{
    public List<Account> Accounts { get; set; }

    public void ImportAccounts();
    public void ExportAccounts();
}