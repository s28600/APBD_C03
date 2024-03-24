namespace APDB_C03.Containers;

public abstract class BaseContainer
{
    protected double MaxLoad { get; }
    protected double Weigth { get; }
    protected double Heigth { get; }
    protected double Depth { get; }
    protected double Load { get; set; } = 0;
    protected string SerialNum { get; set; } = "KON";

    protected BaseContainer(double maxLoad, double weigth, double heigth, double depth)
    {
        MaxLoad = maxLoad;
        Weigth = weigth;
        Heigth = heigth;
        Depth = depth;
    }

    public abstract void emptyLoad();
    public abstract void addLoad(double addedLoad);
}