using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAndConstant
{
    public class Employee
    {
        // <Access Modifier> -> public, private, protected
        // Constant  --> <Access Modifier> <DataType> <ConstantName> = <Value>

        public static double TAX = 0.03;

        // <Access Modifier> -> public, private, protected
        // Fields  --> <Access Modifier> <DataType> <FieldName> = <IntialValue>

        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        public double calculate() => Wage * LoggedHours;
        public double calculateTax() => calculate() * TAX;
        public double calculateNet() => calculate() - calculateTax();
        public string prints()
        {
            return $"-------------\n"+

            $"First Name :{FName}\n" +
            $"Last Name :{LName}\n" +
            $"Wage :{Wage} \n" +
            $"Logged Hours :{LoggedHours} \n" +
            $"Salry: {calculate()}\n" +
            $"Net Salary :{calculateNet()} \n" +
            $"tax Amount: {calculateTax()}\n";
        }
    }
}