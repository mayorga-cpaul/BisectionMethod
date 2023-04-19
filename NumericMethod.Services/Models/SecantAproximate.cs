namespace NumericMethod.Services.Models;

public class SecantAproximate
{
    public int iteration { get; set; }
    public double Xa { get; set; }
    public double Xb { get; set; }
    public double Fxa { get; set; }
    public double Fxb { get; set; }
    public double Xi_1 { get; set; }
    public double Error { get; set; }
}
