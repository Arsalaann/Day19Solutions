using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Day19Problems
{
    public class Validate
    {
        public static bool ValidateName(string name){
            string pattern=@"^[A-Z][a-z]{3}";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(name);
        }
        public static bool ValidateEmail(string email){
            string pattern=@"^([\w\/_\-]+)(.?)([\w\/_\-]*)@([\w\-]+)((\.(\w){2,3})+)((\.(\w){2,3})+)*$";
            Regex rx=new Regex(pattern);
            return rx.IsMatch(email);
        }
    }
}