using SOLIDExample.Entites;

namespace SOLIDExample.Salaries
{
    /// <summary>
    /// Original requirement
    /// Example 
    /// Bad :- A single method of class responsible for calculating basic salary , when new requirement comes we add a new if condition and solve it
    /// </summary>
    public class BasicSalaryCalulator
    {
        public decimal GetBasicSalary(EmployeeType employeeType)
        {
            decimal salary = 0;
            if (employeeType == EmployeeType.Contract) { }
            return salary;
        }
    }


    /// <summary>
    /// New requirement
    /// </summary>
    public class BasicSalaryCalulatorNew
    {
        public decimal GetBasicSalary(EmployeeType employeeType)
        {
            decimal salary = 0;
            
            if (employeeType == EmployeeType.Contract) { }
            else  if (employeeType == EmployeeType.Parttime) { }

            return salary;
        }
    }


    public enum  EmployeeType
    {
        Contract,
        Parttime
    }
}
