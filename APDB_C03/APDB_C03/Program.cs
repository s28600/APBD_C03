using APDB_C03.Containers;

namespace APDB_C03;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer l1 = new LiquidContainer(20000, 3.5, 200, 900, "paliwo");
        l1.addLoad(15000);
        LiquidContainer l2 = new LiquidContainer(20000, 3.5, 200, 900, "paliwo");
        l2.addLoad(10000);
    }
}