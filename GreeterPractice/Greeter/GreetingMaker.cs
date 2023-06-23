namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        public string Greet(string? name)
        {
            if (name == null)
            {
                return $"Hello, Chief";

            }
            if (name == name.ToUpper())
            {
                return $"HELLO, {name.ToUpper()}!";
            }
            return $"Hello, {name}";
        }
        public string Greet(string name, string name2)
        {
           
                
            return $"Hello, {name} and {name2}!";
            
        }
        public string Greet( params string[] names)
        {


            return $"Hello, {String.Join(",", names)}!";




        }

    }
}