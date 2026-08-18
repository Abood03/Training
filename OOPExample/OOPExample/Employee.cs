class Employee
{
    public const int MinmumLoggedHours = 176;
    public const decimal OverTimeRate = 1.25m;
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Wage {  get; set; }
    public decimal loggedHours { get; set; }
    public virtual decimal Claculate()
    {
        return CalculateBaseSalary() + CalculateOverTime();
    }
    private decimal CalculateBaseSalary()
    {
        return loggedHours * Wage;
    }
    private decimal CalculateOverTime()
    {
        var additionalHours = ((loggedHours - MinmumLoggedHours) > 0 ? loggedHours - MinmumLoggedHours : 0);
        return additionalHours * Wage * OverTimeRate;
    }
    
    public override string ToString()
    {
        return $"\nId: {Id}" +
            $"\nName: {Name}"+
            $"\nloggedHours: {loggedHours}"+
            $"\nWage: {Wage}"+
            $"\nBase Salary: {Math.Round(CalculateBaseSalary(),2):N0}"+
            $"\nOverTime: {Math.Round(CalculateOverTime(),2):N0}"

        ;
    }
}
