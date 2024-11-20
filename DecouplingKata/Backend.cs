using System.Security.Cryptography.X509Certificates;
using DecouplingKata;

public class Backend
{
    public CostExplorer CostExplorer { get; }

    public RegistrationService RegistrationService { get; }

    public Backend(SpecSize specSize)
    {
        CostExplorer = new CostExplorer();
        RegistrationService = new RegistrationService(CostExplorer,specSize);
    }
    public void Register(string name)
    {
        RegistrationService.register(name);
    }
    public int TotalCost(){
        return CostExplorer.TotalCost();
    }
}