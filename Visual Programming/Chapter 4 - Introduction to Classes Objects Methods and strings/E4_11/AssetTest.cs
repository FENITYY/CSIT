using System;
using E4_11;

class AssetTest
{
    static void Main()
    {
        Asset asset1 = new Asset("Book", 70, 0.1m);
        Asset asset2 = new Asset("Pencil", 150, 0.2m);

        Console.WriteLine("Before Increase:");
        Console.WriteLine($"Asset 1 - Depreciation: {asset1.CalculateDepreciation()}, Depreciated Value: {asset1.CalculateDepreciatedValue()}");
        Console.WriteLine($"Asset 2 - Depreciation: {asset2.CalculateDepreciation()}, Depreciated Value: {asset2.CalculateDepreciatedValue()}");

        asset1.IncreaseValueByPercentage(5);
        asset2.IncreaseValueByPercentage(5);

        Console.WriteLine("\nAfter Increase:");
        Console.WriteLine($"Asset 1 - Depreciation: {asset1.CalculateDepreciation()}, Depreciated Value: {asset1.CalculateDepreciatedValue()}");
        Console.WriteLine($"Asset 2 - Depreciation: {asset2.CalculateDepreciation()}, Depreciated Value: {asset2.CalculateDepreciatedValue()}");
    }
}