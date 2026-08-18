using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee { Id = 1,Name="abood",Salary=550m,Department="Cs" };
        Employee e2 = new Employee { Id = 1,Name="abood",Salary=550m,Department="Cs" };
        Employee e3 = e1;
        Console.WriteLine(e1==e2);//references
        Console.WriteLine(e1.Equals(e2));//references
        Console.WriteLine(e1==e3);//content
        Console.WriteLine(7.GetHashCode());
        var ints = new FiveIntegers(1, 2, 3, 4, 5);
        foreach (var i in ints)
        {
            Console.WriteLine(i);
        }
    }
}
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department {  get; set; }
    public override bool Equals(object obj)
    {
        if(obj == null||!(obj is Employee))
        
            return false;

            var emp = obj as Employee;

        return this.Id == emp.Id
            && this.Name==emp.Name
            && this.Salary==emp.Salary 
            && this.Department==emp.Department;

    }
    public override int GetHashCode()
    {
        int hash = 13;
        hash = (hash * 7) + Id.GetHashCode();
        hash = (hash * 7) + Name.GetHashCode();
        hash = (hash * 7) + Salary.GetHashCode();
        hash = (hash * 7) + Department.GetHashCode();
        return base.GetHashCode();
        var ints = new FiveIntegers(1, 2, 3, 4, 5);
        foreach (var item in ints)
        {
            
        }
        
        
    }
    public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
    public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);
}
class FiveIntegers:IEnumerable
{
    int[] _values;
    public FiveIntegers(int n1,int n2,int n3 ,int n4,int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 }; 
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var item in _values)
        {
            yield return item;
        }
    }
    //public IEnumerator GetEnumerator() => new Enumertator(this);
       /* class Enumertator : IEnumerator
    {
        int currentIntIndex = -1;
        FiveIntegers _integers;
        public Enumertator(FiveIntegers integers)
        {
            _integers=integers;

        }

        //public object Current => throw new NotImplementedException();
        public Object Current
        {
            get
            {
                if (currentIntIndex == -1)
                    throw new InvalidOperationException($"Enumeration not started");
                if (currentIntIndex == _integers._values.Length)
                    throw new InvalidOperationException($"Enumeration has Ended");
                return _integers._values[currentIntIndex];

            }
        }

        public bool MoveNext()
        {
            if (currentIntIndex >= _integers._values.Length - 1)
                return false;
            return ++currentIntIndex<_integers._values.Length;
        }
            
        public void Reset()=> currentIntIndex = -1;
        
    }*/
}