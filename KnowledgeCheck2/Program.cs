class ComputerPart
{
    public string brand;
}
class Monitor : ComputerPart
{
    public string resolution;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Monitor>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var monitor = new Monitor();

            Console.WriteLine("Enter the value for brand");
            monitor.brand = Console.ReadLine();


            Console.WriteLine("Enter the value for resolution");
            monitor.resolution = Console.ReadLine();


            recordList.Add(monitor);
        }


        // Print out the list of records using Console.WriteLine()
        
        
        foreach(var monitor in recordList)
        {
            Console.WriteLine(monitor);
        }
    }
}