namespace APDB_C03.Containers;

public class BaseContainer
{
    protected double MaxLoad { get; }
    protected double Weigth { get; }
    protected double Heigth { get; }
    protected double Depth { get; }
    protected double Load { get; set; }
    protected string SerialNum { get; }

    public BaseContainer(double maxLoad, double weigth, double heigth, double depth, double load, string serialNum)
    {
        MaxLoad = maxLoad;
        Weigth = weigth;
        Heigth = heigth;
        Depth = depth;
        Load = load;
        SerialNum = serialNum;
    }
    
    
}