namespace DecouplingKata;

public class CostExplorer(){
	private int totalCost = 0;
 
	public void append(int cost) {
	    totalCost += cost;
	}
 
	public int TotalCost(){return totalCost;}
 
}
