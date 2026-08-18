using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Monye m1 = new Monye(10);
        Monye m2 = new Monye(20);
        Console.WriteLine($"Mony m1: ${m1.Amount}, Mony m2 ${m2.Amount}");

        Monye m3 = m1 + m2;
        Console.WriteLine($"Mony m3: ${m3.Amount}");
    }
}

class Monye
{
    private decimal amount;
    public decimal Amount => amount;

    public Monye(decimal value)
    {
        this.amount = Math.Round(value, 2);
    }

    // Operator Overloading: Allows standard operators (>, <, +, etc.) to be used with custom objects.
    // Rule: Comparison operators must always be overloaded in matching pairs (e.g., > and <).
    public static bool operator >(Monye m1, Monye m2)
    {
        return m1.Amount > m2.Amount;
    }

    public static bool operator <(Monye m1, Monye m2)
    {
        return m1.Amount < m2.Amount;
    }

    // Rule: <= and >= must also be overloaded as a pair. 
    public static bool operator <=(Monye m1, Monye m2)
    {
        return m1.Amount <= m2.Amount;
    }

    public static bool operator >=(Monye m1, Monye m2)
    {
        return m1.Amount >= m2.Amount;
    }

    // Rule: Equality operators (== and !=) must be overloaded as a pair.
    // Note: It's highly recommended to also override Equals() and GetHashCode() when overloading == and !=.
    public static bool operator !=(Monye m1, Monye m2)
    {
        return m1.Amount != m2.Amount;
    }

    public static bool operator ==(Monye m1, Monye m2)
    {
        return m1.Amount == m2.Amount;
    }

    // Binary Operator Overload: Takes two operands (m1, m2) and defines how they are added.
    // It returns a completely new instance of Monye to avoid modifying the original objects.
    public static Monye operator +(Monye m1, Monye m2)
    {
        return new Monye(m1.Amount + m2.Amount);
    }

    // Unary Operator Overload: Takes a single operand and defines behavior for incrementing.
    public static Monye operator ++(Monye m1)
    {
        var value = m1.amount;
        return new Monye(++value);
    }

    // Unary Operator Overload: Defines behavior for decrementing.
    public static Monye operator --(Monye m1)
    {
        var value = m1.amount;
        return new Monye(--value);
    }
}