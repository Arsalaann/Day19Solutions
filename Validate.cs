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
    }
}