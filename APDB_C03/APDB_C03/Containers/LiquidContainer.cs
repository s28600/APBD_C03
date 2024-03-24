using System.Transactions;
using APDB_C03.Exceptions;
using APDB_C03.Interfaces;

namespace APDB_C03.Containers;

public class LiquidContainer : BaseContainer, IHazardNotifier
{
    private static int Id = 1;
    private static String[] DangeousTypes = {"paliwo"};
    private string LoadType { get; }
    private bool IsDangeous { get; set; } = false;

    public LiquidContainer(double maxLoad, double weigth, double heigth, double depth, string loadType) : base(maxLoad, weigth, heigth, depth) 
    {
        LoadType = loadType;
        
        foreach (var type in DangeousTypes)
            if (loadType.Equals(type)) IsDangeous = true;
        
        SerialNum += "-L-" + Id;
        Id++;
    }

    public override void emptyLoad()
    {
        Load = 0;
    }

    public override void addLoad(double addedLoad)
    {
        var newLoad = Load + addedLoad;
        
        if (newLoad > MaxLoad)
            throw new OverfillException();
        
        if (IsDangeous && newLoad > MaxLoad*0.5)
            NotifyHazard("Exceeded load capacity for dangerous loads (50%). Operation blocked.");
        else if (newLoad > MaxLoad*0.9)
            NotifyHazard("Exceeded load capacity (90%). Operation blocked.");
        else {
            Load = newLoad;
            Console.WriteLine("Added " + addedLoad + "kg of load to container " + SerialNum + ". Capacity is at " + Load/MaxLoad*100 + "% now.");
        }
    }

    public void NotifyHazard(string text)
    {
        Console.WriteLine("Dangerous operation regarding container " + SerialNum + ":");
        Console.WriteLine(text);
    }
}