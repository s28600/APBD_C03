﻿using APDB_C03.Interfaces;
using APDB_C03.Exceptions;

namespace APDB_C03.Containers;

public class GasContainer : BaseContainer, IHazardNotifier
{
    private static int Id = 1;
    private double Psi { get; set; }
    public GasContainer(double maxLoad, double weigth, double heigth, double depth) : base(maxLoad, weigth, heigth, depth)
    {
        SerialNum += "-G-" + Id;
        Id++;
    }

    public override void emptyLoad()
    {
        Load *= 0.05;
        Console.WriteLine("Container emptied.");
    }

    public override void addLoad(double addedLoad)
    {
        var newLoad = Load + addedLoad;
        
        if (newLoad > MaxLoad)
            throw new OverfillException();
    }

    public void NotifyHazard(string text)
    {
        Console.WriteLine("Dangerous operation regarding container " + SerialNum + ":");
        Console.WriteLine(text);
    }
}