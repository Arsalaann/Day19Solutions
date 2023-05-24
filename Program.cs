namespace Day19Problems{
    class Program{
        public static void Main(string [] args){
            Console.Write("Enter First and last name: ");
            string name=Console.ReadLine();
            while(Validate.ValidateName(name)!=true){
                Console.Write("Enter a valid Firstname: ");
                name=Console.ReadLine();
            }
            string lastName=Console.ReadLine();
            while(Validate.ValidateName(lastName)!=true){
                Console.Write("Enter a valid Lastname: ");
                lastName=Console.ReadLine();
            }
            
        }
    }
}