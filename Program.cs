namespace Day19Problems{
    class Program{
        public static void Main(string [] args){
            // Console.Write("Enter First and last name: ");
            // string name=Console.ReadLine();
            // while(Validate.ValidateName(name)!=true){
            //     Console.Write("Enter a valid Firstname: ");
            //     name=Console.ReadLine();
            // }
            // string lastName=Console.ReadLine();
            // while(Validate.ValidateName(lastName)!=true){
            //     Console.Write("Enter a valid Lastname: ");
            //     lastName=Console.ReadLine();
            // }
            // Console.Write("Enter email: ");
            // string email=Console.ReadLine();
            // while(Validate.ValidateEmail(email)!=true){
            //     Console.Write("Enter a valid Email: ");
            //     email=Console.ReadLine();
            // }
            // Console.Write("Enter phone number: ");
            // string number=Console.ReadLine();
            // while(Validate.ValidateNumber(number)!=true){
            //     Console.Write("Enter a valid Nunmber: ");
            //     number=Console.ReadLine();
            // }
            // Console.Write("Enter password: ");
            // string password=Console.ReadLine();
            // while(Validate.ValidatePassword(password)!=true){
            //     Console.Write("Enter a valid password: ");
            //     password=Console.ReadLine();
            // }

            string []names={"abc@yahoo.com",
                            "abc-100@yahoo.com",
                            "abc.100@yahoo.com",                  
                            "abc111@abc.com",
                            "abc-100@abc.net",
                            "abc.100@abc.com.au",
                            "abc@1.com",                         
                            "abc@gmail.com.com",
                            "abc+100@gmail.com",
                        };
            int res=0;
            foreach(var name in names){
                if(Validate.ValidateEmail(name)==true)
                    res++;
            }
            Console.WriteLine($"{res} emails passed out of {names.Length}");
            
        }
    }
}