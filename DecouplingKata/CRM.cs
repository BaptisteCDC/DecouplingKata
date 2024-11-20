
using DecouplingKata;

public class CRM
{
private CostExplorer CostExplorer;
private readonly SpecSize SpecSize;

    public List<string> Users { get; private set; }

    public void createAccount(String username) {
    int processingTime = SpecSize == SpecSize.Large ? 1 : 3;
    int carbonCost = SpecSize == SpecSize.Large ? 10 : 3;
        Users.Append(username);
    Thread.Sleep(processingTime);
    CostExplorer.append(carbonCost);
}

public CRM(CostExplorer costExplorer, SpecSize specs)
{
    CostExplorer = costExplorer;
    SpecSize = specs;
    Users = new List<string>();
}
}