namespace APDB_C03.Containers;

public class CooledContainer : BaseContainer
{
    private static int _id = 1;
    private string LoadType { get; }
    private double Temp { get; set; }
    public CooledContainer(double maxLoad, double weight, double height, double depth) : base(maxLoad, weight, height, depth)
    {
        SerialNum += "-G-" + _id;
        _id++;
    }

    public override void EmptyLoad()
    {
        throw new NotImplementedException();
    }

    public override void AddLoad(double addedLoad)
    {
        throw new NotImplementedException();
    }
}