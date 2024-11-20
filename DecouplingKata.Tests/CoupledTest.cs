namespace DecouplingKata.Tests;

public class CoupledTest
{
    [Fact]
    public void testRegister(){
	var start = DateTime.Now;
	Backend backend = new Backend(SpecSize.Small);
	backend.Register("Baptiste");
	backend.Register("Cyrille");
	var end = DateTime.Now;
    var duration = end - start;
    Assert.True(duration.Seconds < 7);
    Assert.True(backend.TotalCost()< 7);// SLA not met
    }
}