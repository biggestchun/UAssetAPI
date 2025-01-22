using System;
using UAssetAPI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World from UAssetAPI Example!");
        
        try
        {
            // Create a new UAsset to verify the library reference works
            var asset = new UAsset();
            Console.WriteLine("Successfully created UAsset instance");
            
            // Show the version of the UAsset API being used
            Console.WriteLine($"UAssetAPI Version: {typeof(UAsset).Assembly.GetName().Version}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing UAsset: {ex.Message}");
        }
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
