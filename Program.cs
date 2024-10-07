//syntax

// decimal height = 1.3m;
// decimal length = 1.1m;
// decimal sum = 2.4m;

// System.Console.WriteLine(height + length == sum);

// bool isBoy = true;
// bool isGirl = false;

// System.Console.WriteLine("isBoy : "  + isBoy );
// System.Console.WriteLine("isGirl + " + isGirl );


// if (isBoy)
//         {
//             Console.WriteLine("This person is a boy.");
//         }
//         else
//         {
//             Console.WriteLine("This person is not a boy.");
//         }

//  int age = 20;
//         bool isAdult = age >= 18;  // Assigns true if age is 18 or older
//         Console.WriteLine("Is Adult: " + isAdult);  // Output: Is Adult: True

//         // Combining multiple boolean expressions using logical operators
//         bool hasID = true;
//         bool canEnter = isAdult && hasID;  // Both conditions must be true
//         Console.WriteLine("Can Enter: " + canEnter); // Output: Can Enter: True

using System.Transactions;

// float pi = 3.14f;
//  double bigPi = pi;
//  short age = 22;
//  decimal deciage = age;

// decimal Randomnumber = Convert.ToDecimal("23");
// Console.WriteLine(Randomnumber);
// 1. imlicit casting
// 2. deciage.Tostring()
// 3. explicit casting
// 4. Convert.ToInt32("12")

//explict casting

//  int floratypes = 3232;
//  short smallfloratypes =(short)floratypes; 
//  int Piinteger =(int)bigPi;
//  Console.WriteLine(Piinteger);   


System.Console.WriteLine("Enter your name  ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Enter your age:  ");
string AgeAsString = Console.ReadLine();
System.Console.WriteLine("Converting...  ");
int age = Convert.ToInt32(AgeAsString);
System.Console.WriteLine($"Successfully converted {age}");
int KeshaAge = 22;
int ageDifference = age - KeshaAge;


System.Console.WriteLine($"Sizning yoshingiz va Kescha yoshi o'rtasidagi farq: {ageDifference} yil ");
System.Console.WriteLine($"You are older than or equal to KESCHA {age >= KeshaAge} yil ");
System.Console.WriteLine($"You are older than to KESCHA {age > KeshaAge} yil ");
System.Console.WriteLine($"You are younger than  to KESCHA {age < KeshaAge} yil ");
System.Console.WriteLine($"You are younger than or equal to KESCHA {age <= KeshaAge} yil ");
System.Console.WriteLine($"You are age is equal to KESCHA's age {age == KeshaAge} yil ");
System.Console.WriteLine($"You are age is not equal to KESCHA's age {age != KeshaAge} yil ");














// System.Console.WriteLine("Enter a number with decimal places: ");
// string numberAsString = Console.ReadLine();
// System.Console.WriteLine("Converting to double...");
// double number = Convert.ToDouble(numberAsString);
// System.Console.WriteLine($"Successfully converted {number}");

// System.Console.WriteLine("Enter your height in meters: ");
// string heightAsString = Console.ReadLine();
// System.Console.WriteLine("Converting to double...");
// double height = Convert.ToDouble(heightAsString);
// System.Console.WriteLine($"Successfully converted {height} meters");


