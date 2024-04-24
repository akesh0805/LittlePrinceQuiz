public struct Planeta
{
    public Koordinata Markaz {get; set;}
    public int Radius {get; set;}
    public Planeta():this(new Koordinata(),0) { }
    public Planeta(Koordinata markaz, int radius)
    {
        (Markaz, Radius) = (markaz, radius);
    }
    public readonly bool Ichidami(Koordinata koordinata)
    => Markaz.GachaMasofa(koordinata) < Radius;
}