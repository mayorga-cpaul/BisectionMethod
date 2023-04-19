namespace NumericMethod.Services.Models;

public class FalseRuleAproximate
{
    public int Id { get; set; }
    public double Xa { get; set; }
    public double Xb { get; set; }
    public double Fxa { get; set; }
    public double Fxb { get; set; }
    public double FxaFxb => Fxa * Fxb;
    public bool ThereIsSolution { get; set; }
}
