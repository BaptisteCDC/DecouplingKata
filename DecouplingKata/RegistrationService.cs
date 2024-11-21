using System.Runtime.CompilerServices;
using DecouplingKata;
public class RegistrationService
{
    List<string> Users;

    private CostExplorer CostExplorer;
    private CRM CRM;
    private readonly SpecSize SpecSize;
    public void register(String username)
    {
        int processingTime = SpecSize == SpecSize.Large ? 1 : 3;
        int carbonCost = SpecSize == SpecSize.Large ? 10 : 3;
        Users.Append(username);
        CRM.createAccount(username);
        Thread.Sleep(processingTime * 1000);
        CostExplorer.append(carbonCost);
    }

    public RegistrationService(CostExplorer costExplorer, SpecSize specs)
    {
        CostExplorer = costExplorer;
        SpecSize = specs;
        CRM = new CRM(CostExplorer,SpecSize);
        Users = new List<string>();
    }
}