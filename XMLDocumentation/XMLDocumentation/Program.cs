using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("First Name: ");
            var fname = Console.ReadLine();
            Console.WriteLine("last Name: ");
            var lname = Console.ReadLine();
            Console.WriteLine("hire Date: ");
            DateTime? hireDate = null;
            if (DateTime.TryParse(Console.ReadLine(), out DateTime hdate))
            {
                hireDate = hdate;
            }
            var empId = Generator.GenerateId(fname, lname, hireDate);
            var radndomPassword = Generator.GenerateRandomPassword(8);
            Console.WriteLine($"{{\nId: {empId}, \nFname: {fname},]\nLname: {lname}, \nhire Date: {hireDate}, \npassword {radndomPassword}}}");
        } while (1 == 1);
            
        
    }
    /// <include file="XMLDocumentation.xml"path='docs/members[@=name="XMLDocumentation"]/Generator/*'
    /// <summary>
    /// The main Generator class
    /// </summary>
    /// <remarks>
    /// This class can generate Emp Ids and random password
    /// </remarks>
    public class Generator
{
    /// <value> value of last Id sequence</value>
    /// 
  
    public static int LastIdSequence { get; set; } = 1;

    /// <summary>
    /// Generate Employee Id by processing <paramref name="fname"/><paramref name="fname"/>and <paramref name="hireDate"/></paramref>//refer to method parameter
    /// <list type="bullet">
    /// <item>
    /// <term>II</term>
    /// <description>Employee initials (first letter of <paramref name="lname"/></description>
    /// </item>
    /// </list>
    /// </summary>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    /// <param name="hireDate"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static string GenerateId(string fname, string lname, DateTime? hireDate) 
    {
        if (fname is null)
        {
            throw new InvalidOperationException($"{nameof(fname)} can not be null");
        }
        if (lname is null)
        {
            throw new InvalidOperationException($"{nameof(lname)} can not be null");
        }
        if (hireDate is null)
        {
            hireDate = DateTime.Now;
        }
        else
        {
            if (hireDate.Value.Date < DateTime.Now.Date) //yyyy-mm-dd:mm:ss
            {
                throw new InvalidOperationException($"{nameof(hireDate)}");
            }
            
        }
        var yy = hireDate.Value.ToString("yy");
        var mm = hireDate.Value.ToString("mm");
        var dd = hireDate.Value.ToString("dd");
        var code = $"{lname.ToUpper()[0]}{fname.ToUpper()[0]}{yy} {mm} {dd} {(LastIdSequence++).ToString().PadLeft(2,'0')}";
        return code;
    }
    public static string GenerateRandomPassword(int length)
    {
        const string ValidScope = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = "";
        Random rnd =new Random();
        while (0 < length--)
        {
            result += (ValidScope[rnd.Next(ValidScope.Length)]);
        }
        return result;
    }
}
    

