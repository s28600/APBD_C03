using System.Transactions;
using APDB_C03.Interfaces;

namespace APDB_C03.Containers;

public class LiquidContainer : BaseContainer, IHazardNotifier
{
    private string LoadType { get; }
    private static int id = 1;
    public LiquidContainer(double maxLoad, double weigth, double heigth, double depth, string loadType) : base(maxLoad, weigth, heigth, depth)
    {
        LoadType = loadType;
        SerialNum += "-L-" + id;
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
        else if (LoadType.Equals("paliwo") && load > MaxLoad*0.5)
        {
            NotifyHazard("Exceeded load capacity for dangerous loads.");
        }
        else if (load > MaxLoad*0.9)
        {
            Console.WriteLine(MaxLoad*0.9 + " is max bro");
        }
        else
        {
            Load = load;
            Console.WriteLine("Added " + load + "kg of load to container " + SerialNum);
        }
    }

    public void NotifyHazard(string text)
    {
        Console.WriteLine("Dangerous operation regarding container " + SerialNum + ":");
        Console.WriteLine(text);
    }
}