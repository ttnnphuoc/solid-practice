namespace SOLIDExample.Salaries
{
    /// <summary>
    /// Single Responsibility
    /// Good :- A base abstract class with abstract method and children class override it according their needs
    /// </summary>
    public abstract class BasicSalary
    {
        public abstract double GetBasicSalary(EmployeeType employeeType);
    }

    /// <summary>
    /// Open/Close Principle
    /// </summary>
    public class ParttimeEmployeeBasicSalary : BasicSalary
    {
        public override double GetBasicSalary(EmployeeType employeeType)
        {
            return 0;
        }
    }
    /// <summary>
    /// Open/Close Principle
    /// </summary>
    public class ContractEmployeeBasicSalary : BasicSalary
    {
        public override double GetBasicSalary(EmployeeType employeeType)
        {
            return 0;
        }
    }
}
