namespace NumericMethod.Services.Models;

public class NewthonRhapsonAproximate
{
    public int Iteration { get; set; }
    public double Xi { get; set; }
    public double Fxi { get; set; }
    public double DerivateFxi { get; set; }
    public double Xi_1 => Xi - Fxi / DerivateFxi;
}
