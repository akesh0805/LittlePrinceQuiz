
public struct Koordinata
{
    public int X {get; set;}
    public int Y {get; set;}

    public Koordinata() : this(0,0) {}

    public Koordinata(int x, int y) => (X,Y) = (x,y);

    public readonly double GachaMasofa(Koordinata koordinata2)
    {
        var a = X - koordinata2.X;
        var b = Y - koordinata2.Y;
        var c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        return c;
    }


}