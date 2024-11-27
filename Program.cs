// Everything learnt at https://www.youtube.com/watch?v=q_F4PyW8GTg

public class FirstEntry
{
    
    public static void Main(string[] arg)
    {
        
        ForLoop();
        Console.ReadKey();
    }
    public static void UserInputParse()
    {
        // assigning userInput to variables
        Console.WriteLine("Please enter the first number: ");
        string num1 = Console.ReadLine();
        Console.WriteLine("Please enter the second number: ");
        string num2 = Console.ReadLine();

        // change variables type
        int num1toInt = Int32.Parse(num1);
        int num2toInt = Int32.Parse(num2);

        int result = num1toInt + num2toInt;
        Console.WriteLine(result);
    }
    public static void CatchingErrors()
    {
        // using the same codes as UserInput
        Console.WriteLine("Please enter the first number: ");
        string num1 = Console.ReadLine();
        Console.WriteLine("Please enter the second number: ");
        string num2 = Console.ReadLine();

        // try to look through the code and catch for errors then stop the program
        // this is in order to not crash the program
        try 
        {
            // any variables that is inside try{} cannot be used outside it
            int num1toInt = Int32.Parse(num1);
            int num2toInt = Int32.Parse(num2);
            int result = num1toInt + num2toInt;
            Console.WriteLine(result);
        }
        catch (FormatException) // there are a lot of exceptions, use throw; to identify such error
        {
            Console.WriteLine("Enter a number.");
        }
        catch (OverflowException) {
            Console.WriteLine("Format Overflowed.");
        }
    }
    public static void Operators()
    {
        int num1 = 5;
        int num2 = 3;
        int num3;


        // unary operators
        num3 = -num1;
        Console.WriteLine("num3 is {0}",num3);
        
        bool isSunny = true;
        // ! to make it opposite value
        Console.WriteLine("is it sunny? {0}", !isSunny);

        // increment operators
        int num = 0;
        num++;
        Console.WriteLine("num is {0}", num);
        // increment on the same line
        Console.WriteLine("num is {0}", ++num);
        Console.WriteLine("num is {0}", ++num);

        // decrement
        num--;
        Console.WriteLine("num is {0}", num);
        Console.WriteLine("num is {0}", num--);
        Console.WriteLine("num is {0}", --num);

        int result;
        result = num1 + num2;
        Console.WriteLine("result of num1 + num2 is {0}",result);

        // divide and get the remains
        result = num1 % num2;
        Console.WriteLine("result of num1 % num2 is {0}",result);
        
        // relation and type operators or comparasions
        bool isitLower = num1 < num2;
        Console.WriteLine("result of num1 < num2 is {0}",isitLower);

        // equal operators
        bool isEqual = num1 == num2;
        Console.WriteLine("result of num1 == num2 is {0}",isEqual);

        isEqual = num1 != num2;
        Console.WriteLine("result of num1 != num2 is {0}",isEqual);

        // conditionals operators
        bool isLowerandSunny;
        // condition1 AND condition2
        isLowerandSunny = isitLower && isSunny;
        Console.WriteLine("result of isitLower && isSunny is {0}",isLowerandSunny);
        // condition1 OR condition2
        isLowerandSunny = isitLower || isSunny;
        Console.WriteLine("result of isitLower || isSunny is {0}",isLowerandSunny);
    }
    public static void IfElseTryParse()
    {
        // userInput
        Console.WriteLine("What's the temperature?");
        string temperatureString = Console.ReadLine();
        // changing string to int
        // alternative: int temperature = Convert.ToInt32(Console.ReadLine());
        // there are possible problems so we will use try and catch
        // int temperature = Int32.Parse(temperatureString);
        int temperature;
        int numTemp; // store parsed value here


        // bool checkUser = Int32.TryParse(temperatureString, out numTemp); (another way to check)
        // attempt to change temperatureString to int storing that parsed value in numTemp
        if (Int32.TryParse(temperatureString, out numTemp))
        {
            temperature = numTemp; // if Parsing worked, it will store that, once a string, now an int, into numTemp
            // that numTemp, which is the int of temperatureString is equal to temperature
        }
        else
        {
            temperature = 0; // if Parsing didnt work, alert the user that he has entered the wrong format and set to 0
            Console.WriteLine("The number entered was not in the correct format so it was automatically set to 0.");
        }
        if (temperature < 10){ // if this is true then write this
            Console.WriteLine("Take the coat and wear warm pants.");
        } else if (temperature == 10) // if the condition above is false THEN use else if
        {
            Console.WriteLine("Long pants and jacket.");
        } else // if all is false, then this.
        {
            Console.WriteLine("Shorts are enough");
        }
    }
    public static void NestedIf()
    {
        bool isRegistered = true;
        bool isAdmin = false;
        Console.WriteLine("Please enter your username.");
        string userInput = Console.ReadLine();

        if (isRegistered && userInput != "" && userInput.Equals("admin"))
        {
            Console.WriteLine("Welcome, registered user");
            Console.WriteLine("Welcome, " + userInput);
            Console.WriteLine("Welcome, Admin");
        }
        // if either is true, do this.
        if (isRegistered || isAdmin)
        {
            Console.WriteLine("You are logged in.");
        }
    }
    public static void SwitchCase()
    {
        int age = 25;

        // another way to handle if statements
        switch (age)
        {
            case 15: // if age is 15 then...
                Console.WriteLine("Too young.");
                break;
            case 25: // if age is 25 then...
                Console.WriteLine("Go ahead.");
                break;
            default: // if it is neither 15 nor 25 then...
                Console.WriteLine("How old are you then?");
                break; // break out of switch statement
        }

        // another way to handle switch cases
        if (age == 15){
            Console.WriteLine("Too young.");
        } else if (age == 25) {
            Console.WriteLine("Go ahead");
        } else {
            Console.WriteLine("How old are you then?");
        }
    }
    public static void IfShortcut()
    {
        // in full
        int temperature = -5;
        string stateofmatter;
        /* if (temperature < 0)
        {
            stateofmatter = "solid";
        }
        else
        {
            stateofmatter = "liquid";
        } */

        // in short, ? if true, : if false
        temperature = 100;
        stateofmatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
                      //if temperature > 100        else if temperature < 0
        Console.WriteLine("The state is {0}", stateofmatter);
    }
    public static void ForLoop()
    {
        for (int i = 1; i <= 10; i++) 
        {
            int sum = 0;
            sum = sum + i;
            Console.WriteLine("{0}", i);
        }
              
    }
    public static void DoWhileLoop()
    {
        int nameLength = 0;
        int lengthOfText = 0;
        do
        {
            Console.WriteLine("Please enter a name of a friend:");
            string name = Console.ReadLine(); // user input
            nameLength = name.Length; // nameLength = to the length of the input name
            lengthOfText += nameLength; // that number of words in the name will be plus with lengthOfText 
        } while (lengthOfText < 20);
        Console.WriteLine("That's enough!");
        // example coming back later.
        Console.WriteLine("Enter the number of student:");
        int studentNum = Convert.ToInt32(Console.ReadLine());
        int studentAmmountOfScore = 0;
        int lengthOfScore = 0;
        do
        {
            Console.WriteLine("Enter the student scores:");
            string score = Console.ReadLine();
            int scoreToInt = Int32.Parse(score); // Parse to int
            studentAmmountOfScore = score.Length;
            lengthOfScore += studentAmmountOfScore;

        } while (lengthOfScore < studentNum);
            Console.WriteLine("The average of the class is {0}");
    }
    public static void WhileLoop()
    {
        string peopleCounter = ""; // this will start the program immediately because it is ""
        int peopleAmmount = 0;
        while (peopleCounter.Equals("")) // as long as you press enter, it loops
        {
            Console.WriteLine("There are currently: {0}", peopleAmmount + " people");
            Console.WriteLine("Please press enter to add a number. Press anything else + enter to finish counting");
            peopleCounter = Console.ReadLine(); // see if you press enter or not, if not, stop loop
            peopleAmmount++;
        }
        Console.WriteLine("There are currently {0} people, press enter to exit.", peopleAmmount);
    }
    public static void BreakContinue()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 3)
            {
                Console.WriteLine("yo this is a 3.");
                //break; // break out of loop and continue the line of code below
                continue; // WriteLine and continue the code
            }
        }
        
    }
    public static void Arrays()
    {
        // initializing an array
        int[] grades = new int[5];
        grades[0] = 20;
        grades[1] = 15;
        grades[2] = 10;

        Console.WriteLine("The grade at index 0 is {0}", grades[0]);
        Console.WriteLine("If you want to change index 0 grade, please type a number");
        // assign a value at index 0
        grades[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("The grade at index 0 is {0}", grades[0]);

        // another way of initializing an array
        int[] gradesOfMathStudentsA = {20,13,12,15,2};

        // third way of initializing an array
        int[] gradesOfMathStudentsB = new int[] {10,2,35,12,10,1};

        Console.WriteLine("The length of gradesOfMathStudentsA is {0}", gradesOfMathStudentsA.Length);
    }
    public static void Foreach()
    {
        string[] bestFriends = {"Phong", "Tus", "Thai", "Lam", "Hung Anh"};
        
        foreach (var i in bestFriends)
        {
            Console.WriteLine("Good morning {0}", i);
        }
    }
    public static void DimensionalArrays()
    {
        // Declare 2D array
        string[,] matrix;

        // declade 3D array
        string[,,] threeD;

        // 2D array
        int[,] array2D = new int[,]
        {
            {1,2,3}, // row 0
            {4,5,6}, // row 1
            {7,8,9}  // row 2
        };

        // 3D array
        string[,,] array3D = new string[,,]
        {
            {
                {"000", "001"},
                {"010", "100"}
            },
            {
                {"002", "003"},
                {"004", "005"}
            },
            {
                {"006","007"},
                {"008","009"}
            }
        };

        string[,] array2DString = new string[3, 2]
        {
            {"one", "two"},
            {"three", "four"},
            {"five", "six"}
        };

        array2DString[1,1] = "chicken";

        
        Console.WriteLine("Number {0}", array2D[2,0]);
    }

}
