// See https://aka.ms/new-console-template for more information
// Gives the resistor value with seleccting the colors order
// Gives the resistor colors with the value

/*
  - Create a string array with the default values of the band: black, brown, ...
  - Create one function for  4 band read
    * Use a foreach to read all the possible band color
    * Use an if to select the respective value for that color
    * 
 */
namespace resistor;

public class Resistor{
    public struct resistorColors{
        string[] bandColors = new string[] { "black", "brown", "red",
                                             "orange", "yellow", "green",
                                             "blue", "violet", "grey",
                                             "white", "gold", "silver" };
                                             
                                             
                         }
                         
   
  // input resistor colors and output resistor value
 
         
    
    
    static void Main(string [] args){
        Console.Write("Resistor value by colors");
        
    }
}
