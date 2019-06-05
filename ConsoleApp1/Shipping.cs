using System;

public class Shipping
{
    public static int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
    {
        var minimalLgBox = items / (availableLargePackages * 5) > 0 ? availableLargePackages : GetMinorValue(items, availableLargePackages);
        var minimalSmBox = items % (minimalLgBox * 5);
        return minimalLgBox + minimalSmBox;

    }
    public static int GetMinorValue(int things, int LgBoxes)
    {
        do
        {
            LgBoxes--;
        } while (things / (LgBoxes * 5) == 0);

        return LgBoxes;
    }
}