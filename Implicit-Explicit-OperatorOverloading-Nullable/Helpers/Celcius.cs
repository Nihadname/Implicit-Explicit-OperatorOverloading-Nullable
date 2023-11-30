namespace Implicit_Explicit_OperatorOverloading_Nullable.Models
{
    public class Celcius
    {
        public int Degree { get; set; }
        public Celcius(int degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celcius s)
        {
            return new Kelvin(s.Degree +273);
        }
    }
}
