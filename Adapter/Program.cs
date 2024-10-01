namespace Adapter.NetOptimized;

using static System.Console;

public class Program
{
    public static void Main()
    {
        // Non-adapted chemical compound 
        var unknown = new Compound();
        unknown.Display();

        // Adapted chemical compounds
        var water = new RichCompound(Chemical.Water);
        water.Display();

        var benzene = new RichCompound(Chemical.Benzene);
        benzene.Display();

        var ethanol = new RichCompound(Chemical.Ethanol);
        ethanol.Display();
        ReadKey();
    }
}
public enum Chemical
{
    Water,
    Benzene,
    Ethanol
}

/// <summary>
/// State enumeration
/// </summary>
public enum State
{
    Boiling,
    Melting
}

