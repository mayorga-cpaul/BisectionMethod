namespace NumericMethod.Services.Models;

public class BisectionAproximate
{
    public int I { get; set; }
    public double Xa { get; set; }
    public double Xb { get; set; }
    public double Xr => (Xa + Xb) / 2;
    public double Fxa { get; set; }
    public double Fxr { get; set; }
    public double FxaFr => Fxa * Fxr;
    public double Ea { get; set; }
}
