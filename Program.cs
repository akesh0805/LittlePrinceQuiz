Console.Write("Urinishlar sonini kiriting- ");
var urinishSoni = int.Parse(Console.ReadLine()!);
while (urinishSoni-- > 0)
{
    var kesishlarSoni = 0;
    Console.Write("Shaxzoda va malika koordinatalarini kiriting- ");
    var koordinatalar = Console.ReadLine()!
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

    var prince = new Koordinata(koordinatalar[0], koordinatalar[1]);
    var princess = new Koordinata(koordinatalar[2], koordinatalar[3]);
    Console.Write("Planetalar sonini kiriting- ");
    var planetalarSoni = int.Parse(Console.ReadLine()!);

    while (planetalarSoni-- > 0)
    {
        Console.Write("Planeta koordinatalarini kiriting- ");
        var planetaKoor = Console.ReadLine()!
        .Split(' ')
        .Select(int.Parse)
        .ToArray();

        var planetaMarkaz = new Koordinata(planetaKoor[0], planetaKoor[1]);
        var planetaRadius = new Planeta(planetaMarkaz, planetaKoor[2]);

        var princeIchidami = planetaRadius.Ichidami(prince);
        var princessIchidami = planetaRadius.Ichidami(princess);

        var kesibOtadimi = princeIchidami ^ princessIchidami;
        if (kesibOtadimi)
        {
            kesishlarSoni++;
        }
    }
    Console.WriteLine(kesishlarSoni);
}