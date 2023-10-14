using System.Security.Principal;
using System;
using SOLIDExample.Entites;

namespace SOLIDExample.Users
{
    /*
     * Example:
     * Bad :- Single class responsible for Signup, Login , Logging Error and Sending the Email.
     * 
     * Good :- Different classes for different purpose
     *      User Account related (Signup and Login)
     *      Sending Email related(SendEmail)
     *      Logging related(LogInformation)
     * Now in future we can add LogError,LogWarning in our logging class and ForgotPasword in User Account.
     * Suppose if we had kept a single class and we add new methods in that class then its impact would have been everywhere where class has dependencies.
     * In current example I have used just class for demo one can use interface example as well
    */

    /// <summary>
    /// Bad: Single class responsible for Signup, Login , Logging Error and Sending the Email.
    /// </summary>
    public class User1
    {
        public bool LogIn(string UserName, string Password) {return false;}
        public bool SignUp(UserDto user) { return false;}
        public bool SendEmail(SendEmailDto sendEmailDto) { return false;}

        public void LogInformation(string message) { }
    }

    /// <summary>
    /// User Account related (Signup and Login)
    /// </summary>
    public class User
    {
        public bool LogIn(string UserName, string Password) { return false; }
        public bool SignUp(UserDto user) { return false; }
    }

    /// <summary>
    /// Sending Email related(SendEmail)
    /// </summary>
    public class EmailService 
    {
        public bool SendEmail(SendEmailDto sendEmailDto) { return false; }

    }

    /// <summary>
    /// Logging related(LogInformation)
    /// </summary>
    public class LogService
    {
        public void LogInformation(string message) { }
    }
}
