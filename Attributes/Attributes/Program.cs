using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Update[] updates = {
        new Update(1,"security update") ,
        new Update(2,"ui enhancement") ,
        new Update(3,"security update") ,
        new Update(4,"security update")
      };
        UpdateProcessor.Download(updates);
        //UpdateProcessor.Install(updates);
        UpdateProcessor.DownloadAndInstall(updates);
    }
}
class UpdateProcessor
{
    //var attr = new ObsoleteAttribute("this method will not be supported in the next release consider using DownloadAndInstall() instead");
    [Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead",false)]  //we specify an attribute by placing it above the declaration for the element between square brackets

    public static void Download(Update[] updates)
    {
        foreach (var item in updates)
        {
            Console.WriteLine($"Downloading {item}");
            System.Threading.Thread.Sleep(750);
        }
    }
        
        public static void Install(Update[] updates)
        {
            foreach (var item in updates)
            {
                Console.WriteLine($"installing {item}");
                System.Threading.Thread.Sleep(750);
            }
        } 
    public static void DownloadAndInstall(Update[] updates)
    {
        for (int i = 0; i < updates.Length; i++)
        {
            Console.WriteLine($"Downloading {updates[i]}");
            System.Threading.Thread.Sleep(750);
            Console.WriteLine($"Installing {updates[i]}");
            System.Threading.Thread.Sleep(750);

        }
    }
    
}
[DebuggerDisplay("No: {no}, Title: {title}")]
class Update
{
    private int no;
    private string title;

    public Update(int no, string title)
    {
        this.no = no;
        this.title = title;
    }
    public override string ToString()
    {
        return $"{no} - {title}";
    }
}