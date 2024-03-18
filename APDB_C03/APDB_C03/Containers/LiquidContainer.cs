using System.Transactions;

namespace APDB_C03.Containers;

public class LiquidContainer : BaseContainer
{
    private static int id = 1;
    public LiquidContainer(double maxLoad, double weigth, double heigth, double depth) : base(maxLoad, weigth, heigth, depth)
    {
        SerialNum += "L" + id;
        id++;
    }

    public override void emptyLoad()
    {
        Load = 0;
    }

    public override void addLoad(double load)
    {
        if (load > MaxLoad)
        {
            throw new OverflowException();
        }
        
        
    }
}