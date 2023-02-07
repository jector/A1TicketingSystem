using System.Threading.Channels;

namespace TicketingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets.csv";
            string choice;
            do
            {
                Console.WriteLine("1) Read data from file");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    StreamReader sr = new StreamReader(file);
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        string[] arr = line.Split(',');
                        Console.WriteLine($"TicketID: {arr[0]}, Summary: {arr[1]},  Status: {arr[2]},  Priority: {arr[3]},  Submitter: {arr[4]},  Assigned: {arr[5]},  Watching: {arr[6]}");
                    }
                }
                else if (choice == "2")
                {
                    StreamWriter sw = new StreamWriter(file, true);
                    Console.WriteLine("Enter a TicketID.");
                    string ticketID = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Summary.");
                    string summary = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Status.");
                    string status = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Priority.");
                    string priority = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Submitter.");
                    string submitter = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Assigned.");
                    string assigned = Console.ReadLine();
                    
                    Console.WriteLine("Enter a Watcher.");
                    string watching = Console.ReadLine();
                    
                    /*
                    string[] watching = new string[7];
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Enter a user to watch.");
                        watching[i] = Console.ReadLine();
                        Console.WriteLine("Enter other user to watch (Y/N)?");
                        string resp2 = Console.ReadLine().ToUpper();
                        if (resp2 != "Y") { break; }
                    }
                    
                    //var watchersArr = watching.ToArray();

                   
                    for (int j = 0; j < watching.Length; j++)
                    {
                        sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching[j]}");
                    }
                    */
                    /*
                    List<string> watching = new List<string>();
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Enter a user to watch.");
                        watching.Add( Console.ReadLine());
                        Console.WriteLine("Enter other user to watch (Y/N)?");
                        string resp2 = Console.ReadLine().ToUpper();
                        if (resp2 != "Y") { break; }
                    }

                    var watchersArr = watching.ToArray();
                    
                    sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned}");
                    for (int j = 0; j < watchersArr.Length; j++)
                    {
                        sw.WriteLine($"{watchersArr[j]}");
                    }
                    */
                    
                    sw.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching}");
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}