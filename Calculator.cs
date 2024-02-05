using System;
class Calculator {
  static void Main() {
      
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    decimal num1 = Convert.ToDecimal(input);
    
    Console.Write("Enter second number: ");
    string input2 = Console.ReadLine();
    decimal num2 = Convert.ToDecimal(input2);
    
    Console.Write("Enter the operation to be performed: ");
    string operation = Console.ReadLine();
    
    switch (operation) {
    case "+":
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1-num2);
        break;
    case "/":
        if (num2!=0){
        Console.WriteLine(num1/num2); 
        }
        else{
            Console.WriteLine("Cannot divide by 0");
        }
        break;
    case "*":
        Console.WriteLine(num1*num2);
        break;
    case "%":
        Console.WriteLine(num1%num2);
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}
    
  }
}
