namespace Day19Problems{
    class Program{
        public static void Main(string [] args){
            Console.Write("Enter a name: ");
            string name=Console.ReadLine();
            while(Validate.ValidateName(name)!=true){
                Console.Write("Enter a valid name: ");
                name=Console.ReadLine();
            }
            
        }
    }
}