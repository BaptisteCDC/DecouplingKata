namespace DecouplingKata.Tests;

public class CoupledTest
{
    SpecSize spec = SpecSize.Small;
    [Fact]
    public void RegisterShouldTakeLessThan4s(){
	var start = DateTime.Now;
	Backend backend = new Backend(spec);
	backend.Register("Baptiste");
	var end = DateTime.Now;
    var duration = end - start;
    Assert.True(duration.Seconds < 4);
    }

    [Fact]
    public void RegisterShouldCostLessThan5(){
	Backend backend = new Backend(spec);
	backend.Register("Baptiste");
    Assert.True(backend.TotalCost() < 7);
    }

}