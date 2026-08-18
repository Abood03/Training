class Manager : Employee
{
    public const decimal Allowance = 0.05m;
    public override decimal Claculate()
    {
        return base.Claculate() + Allowance * base.Claculate();
    }
    private decimal CalculateAllowance()
    {
        return base.Claculate() + base.Claculate() * Allowance;
    }
    public override string ToString()
    {
        return base.ToString()+
        $"\nAllowance: {Math.Round(CalculateAllowance(),2):N0}"+
        $"\nNet Salary: {Math.Round(this.Claculate(),2):N0}";
    }
}
class Maintenance : Employee
{
    public const decimal Hardship = 100m;
    public override decimal Claculate()
    {
        return base.Claculate() + Hardship * base.Claculate();
    }

    public override string ToString()
    {
        return base.ToString() +
        $"\nHardship: {Math.Round(Hardship, 2):N0}" +
        $"\nNet Salary: {Math.Round(this.Claculate(), 2):N0}";
    }
}
class Sales : Employee
{
    public decimal SalesVolume { get; set; }
    public decimal Commission {  get; set; }

    public override decimal Claculate()
    {
        return base.Claculate() + base.Claculate();
    }
    private decimal CalculateBonus()
    {
        return SalesVolume * Commission;

    }
    
    public override string ToString()
    {
        return base.ToString() +
        $"\nAllowance: {Math.Round(CalculateBonus(), 2):N0}" +
        $"\nCommission: {Math.Round(Commission, 2):N0}" +
        $"\nNet Salary: {Math.Round(this.Claculate(), 2):N0}";
    }
}
class Developer : Employee
{
    public const decimal Commission = 0.03m;
    public bool TackCompleted { get; set; }

    public override decimal Claculate()
    {
        return base.Claculate() + CalculateBonus();
    }
    private decimal CalculateBonus()

    {
        if (TackCompleted)
        {
            return base.Claculate() * Commission;
        }
        return 0; 

    }

    public override string ToString()
    {
        return base.ToString() +
        $"\nTask Compleated: {(TackCompleted?"yes":"No")}" +
        $"\nCommission: {Math.Round(CalculateBonus(), 2):N0}" +
        $"\nNet Salary: {Math.Round(this.Claculate(), 2):N0}";
    }
}
