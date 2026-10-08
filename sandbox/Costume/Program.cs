// Me:
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, World!");

//         List<Costume> myCostumes = new List<Costume>();
//         Costume detective = new Costume();
//         detective._headware = "logo";
//         detective._upperGarment = "suit";
//         detective._lowerGarment = "leggin";
//         detective._footwear = "black shoe";
//         detective._accessories = "gun";
//         myCostumes.Add(detective);

//         foreach (Costume costume in myCostumes)
//         {
//             costume.Output();
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Costume World!");

        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slacks";
        detective._footwear = "dress shoes";
        detective._accessories = "fingerprint kit";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "hairnet";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._footwear = "orthopedic shoes";
        nurse._accessories = "surgical mask";
        myCostumes.Add(nurse);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }

    }
}