
public class Calculator
{
    public static void Main()
    {
        var Cal = new Calculator();
        Console.WriteLine("Hello! Thank you for using the Calculator Tool!\n" +
            "First, enter your desired operator (in text) and then enter each of the operands separately!\n");

        //Lists of the numbers and operators to ensure valid user input
        List<int> num_selections = new List<int>();
        List<string> op_selections = new List<string>();
        List<string> y_n = new List<string>(); //y or n only

        num_selections.Add(1); num_selections.Add(2); num_selections.Add(3); num_selections.Add(4);
        op_selections.Add("Add"); op_selections.Add("Subtract"); op_selections.Add("Multiply"); op_selections.Add("Divide");
        y_n.Add("y"); y_n.Add("n");

        
        //while this is true, user wants to do more calculations. loop will continue
        bool moreCalcs = true;

        while (moreCalcs)
        {
            //Collect customer info
            string usrOperator;
            int operandA;
            int operandB;

            usrOperator = Cal.str_input("Enter the operator: ", op_selections);
            operandA = Cal.int_input("Enter the first operand: ", num_selections);
            operandB = Cal.int_input("Enter the second operand:", num_selections);
            Console.WriteLine(Cal.doMath(usrOperator, operandA, operandB));
                  
            //Check if we want to do another math
            if (Cal.str_input("Do more math?", y_n) == "n")
            {
                moreCalcs = false;
            }
            Console.WriteLine();
        }
    }

    public string str_input(string prompt,List<string> acceptableInput)
    {
        while (true)
        {
            Console.Write(prompt);
            Console.WriteLine(String.Format("-- Expected Input: {0}", string.Join(';', acceptableInput)));
            try
            {
                string readIn = (string)Console.ReadLine();
                foreach (string check in acceptableInput)
                {
                    if (check.ToLower() == readIn.ToLower())
                        return check;
                }
                Console.WriteLine("Unexpected Input");
            }
            catch
            {
                Console.WriteLine("invalid input");
            }
        }
    }

    public int int_input(string prompt, List<int> acceptableInput)
    {
        while (true)
        {
            Console.Write(prompt);
            Console.WriteLine(String.Format("-- Expected Input: {0}", string.Join(';', acceptableInput)));
            try
            {
                int readIn = Convert.ToInt32(Console.ReadLine());
                foreach (int check in acceptableInput)
                {
                    if (check == readIn)
                        return check;
                }
                Console.WriteLine("Unexpected Input");
            }
            catch
            {
                Console.WriteLine("invalid input");
            }
        }
    }

    public string doMath(string selOper, int operandA, int operandB)
    {
        switch (selOper.ToLower())
        {
            //Decision statement: what is the shipping cost based off the type of shipping selected
            case "add":
                return String.Format("{0} + {1} = {2}",operandA.ToString("0"), operandB.ToString("0"), 
                    (operandA + operandB).ToString("0"));

            case "subtract":
                return String.Format("{0} - {1} = {2}", operandA.ToString("0"), operandB.ToString("0"),
                    (operandA - operandB).ToString("0"));

            case "multiply":
                return String.Format("{0} * {1} = {2}", operandA.ToString("0"), operandB.ToString("0"),
                    (operandA * operandB).ToString("0"));

            case "divide":
                try
                {
                    return String.Format("{0} / {1} = {2}", operandA.ToString("0"), operandB.ToString("0"),
                        (operandA / operandB).ToString("0.00"));
                }
                catch
                {
                    return "division problem-- did you divide by 0?";
                }
            default:
                //default to 0
                return "Error-- operator not found";
        }
    }
}