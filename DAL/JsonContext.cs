using System.Text.Json;
using AccountsManagerApp.Model;

namespace AccountsManagerApp.DAL;

public class JsonContext : FileContext, IContext
{
    public List<Account> Accounts { get; set; }

    public JsonContext(string path) : base(path)
    {
    }

    public void ImportAccounts()
    {
        var json = File.ReadAllText(Path);
        Accounts = JsonSerializer.Deserialize<List<Account>>(json);
    }

    public void ExportAccounts()
    {
        var json = JsonSerializer.Serialize(Accounts);
        File.WriteAllText(Path, json);
    }
}