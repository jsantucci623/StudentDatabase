// Student Database
// Jeff Santucci
// 01/26/23

// name                             hometown                           favorite food               
// 1. Billy Mummy                   Mars, Pennsylvania                 Blue Moon Ice Cream
// 2. Horace Cat                    Seattle, Washington                Tuna Cassarole
// 3. Ginger Rogers                 Hollywood, California              Cottage Cheese
// 4. Paula Abdul                   New York City, New York            Spaghetti
// 5. Gingus Kahn                   Hong Kong, China                   Shushi
// 6. Arnold Pig                    Green Acres, Wisonsin              Slop
// 7. Annette Funiccelli            Orlando, Florida                   Lasagna
// 8. Dolly Parton                  Servierville, Tenessee             Chicken
// 9. Paul Newman                   Las Angelos, California            Salad
// 10. John Wayne                   Bute, Montana                      Steak

string[] name = new string[10];
name[0] = "Billy Mummy";
name[1] = "Horace Cate";
name[2] = "Ginger Rogers";
name[3] = "Paula Abdul";
name[4] = "Gingus Kahn";
name[5] = "Arnold Pig";
name[6] = "Annette Funiccelli";
name[7] = "Dolly Parton";
name[8] = "Paul Newman";
name[9] = "John Wayne";

string[] hometown = new string[10];
hometown[0] = "Mars, Pennsylvania";
hometown[1] = "Seattle, Washington";
hometown[2] = "Hollywood, California";
hometown[3] = "New York City, New York";
hometown[4] = "Hong Kong, China";
hometown[5] = "Green Acres, Wisconsin";
hometown[6] = "Orlando, Florida";
hometown[7] = "Servierville, Tenessee";
hometown[8] = "Las Angelos, California";
hometown[9] = "Bute, Montana";

string[] favorite_food = new string[10];
favorite_food[0] = "Blue Moon Ice Cream";
favorite_food[1] = "Tuna Cassarole";
favorite_food[2] = "Cottage Cheese";
favorite_food[3] = "Spaghetti";
favorite_food[4] = "Sushi";
favorite_food[5] = "Slop";
favorite_food[6] = "Lasagna";
favorite_food[7] = "Chicken";
favorite_food[8] = "Salad";
favorite_food[9] = "Steak";

bool isNextStudent = false;
bool isTryAgain = false;
bool isValidNum;

for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine($"{i + 1}. {name[i]}");
}

do
{
    Console.WriteLine("Pick the number of the Student you would like to know more about");
    isValidNum = int.TryParse(Console.ReadLine(), out int nameNum);
    // int nameNum = int.Parse(Console.ReadLine()) - 1;
    
    if (isValidNum == true)
    {
        nameNum = nameNum - 1;

        if ((nameNum < 0) || (nameNum >= name.Length))
        {
            Console.WriteLine("You have entered a number outside the range of the Student Database 1 - 10");
            Console.WriteLine("Would you like to try Again? (y/n)");
            string AnotherTry = Console.ReadLine();
            AnotherTry = AnotherTry.ToLower();

            if (AnotherTry == "y")
            {
                isNextStudent = true;
            }
            else
            {
                isNextStudent = false;
            }
        }
        else
        {
            Console.WriteLine(name[nameNum]);

            do
            {
                Console.WriteLine("Would you like to know more about the Students Hometown or Favorite food?");
                Console.WriteLine("Enter 'h' for Hometown or 'f' for Favorite Food");
                string answer = (Console.ReadLine());

                answer = answer.ToLower();

                if (answer == "h" || answer == "hometown")
                {
                    Console.WriteLine(name[nameNum] + " hometown is " + hometown[nameNum]);
                    isTryAgain = false;
                }
                else if (answer == "f" || answer == "favorite food")
                {
                    Console.WriteLine(name[nameNum] + " favorite food is " + favorite_food[nameNum]);
                    isTryAgain = false;
                }
                else
                {
                    Console.WriteLine("You entered an invalid entry -- Try Again? (y/n)");
                    string tryAgain = (Console.ReadLine());
                    tryAgain = tryAgain.ToLower();

                    if (tryAgain == "y")
                    {
                        isTryAgain = true;
                    }
                    else
                    {
                        isTryAgain = false;
                    }
                }
            } while (isTryAgain);

            Console.WriteLine("Would you like to learn about another Student? (y/n)");
            string nextStudent = Console.ReadLine();
            nextStudent = nextStudent.ToLower();

            if (nextStudent == "y")
            {
                isNextStudent = true;
            }
            else
            {
                isNextStudent = false;
            }
        } 
    } 
    else
    { 
        Console.WriteLine("You have entered an invalid entry! Would you like to try again? (y/n)");
        string anotherTry = Console.ReadLine();
        anotherTry = anotherTry.ToLower();

        if (anotherTry == "y")
        {
            isNextStudent = true;
        }
        else
        {
            isNextStudent = false;
        }
    }
} while (isNextStudent);
