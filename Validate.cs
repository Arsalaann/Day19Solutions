using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Day19Problems
{
    public delegate bool ValidateNameByDelegate(string name);
    public delegate bool ValidateEmailByDelegate(string email);
    public delegate bool ValidateNumberByDelegate(string number);
    public delegate bool ValidatePasswordByDelegate(string password);
    public class Validate
    {
        public ValidateNameByDelegate nameValidation=name=>{
            string pattern=@"^[A-Z][a-z]{3}";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(name);
        };
        public ValidateEmailByDelegate emailValidation=email=>{
            string pattern=@"^([\w\/_\-]+)(.?)([\w\/_\-]*)@([\w\-]+)((\.(\w){2,3})+)((\.(\w){2,3})+)*$";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(email);
        };

        public ValidateNumberByDelegate numberValidation=number=>{
            string pattern=@"[0-9]{2}\s[0-9]{10}$";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(number);
        };

        public ValidatePasswordByDelegate passwordValidation=password=>{
            string pattern=@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(password);
        };
    }
}