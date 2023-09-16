using AccountsManagerApp.DAL;
using AccountsManagerApp.Model;

namespace AccountsManagerApp.BLL;

public class AccountsManager
{
    private readonly IContext _context;

    public AccountsManager(IContext context)
    {
        _context = context;
        
        _context.ImportAccounts();
    }

    public Account? Auth(string login, string password) => _context.Accounts.SingleOrDefault(a => a.Login == login && a.Password == password && !a.IsDelete);
    public List<Account> GetAllAccounts() => _context.Accounts;
    public List<Account> FindAccountsByLogin(string login) => _context.Accounts.Where(a => a.Login == login).ToList();
}