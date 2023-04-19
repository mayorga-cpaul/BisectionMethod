namespace NumericMethod.Services.Models;
public class IteracionNewtonSE
{
    public int NoIteracion { get; set; }
    public double U { get; set; }
    public double V { get; set; }
    public double DerivadaParcialUx { get; set; }
    public double DerivadaParcialUy { get; set; }
    public double DerivadaParcialVx { get; set; }
    public double DerivadaParcialVy { get; set; }
    public double Determinante { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Eax { get; set; }
    public double Eay { get; set; }
}
