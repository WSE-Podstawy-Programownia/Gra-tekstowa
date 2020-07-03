using System;
using System.Threading;

namespace Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool menuRunning = true;

            while (menuRunning)
            {
                String choice = "0";
                Console.WriteLine("Menu");
                Console.WriteLine("1.Game");
                Console.WriteLine("2.Instruction");
                Console.WriteLine("3.Exit");
                Console.WriteLine(" ");

                choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Game");
                        Sleep(2);
                        Game();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Instruction");
                        Instruction();
                        Sleep(2);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        Sleep(2);
                        menuRunning = false;
                        break;

                    default:
                        Console.WriteLine("Wrong choice.");
                        break;
                }

            }
        }

        static void Instruction()
        {
            Console.WriteLine("");
            Console.WriteLine("During game you can choose from two or three possible choices. Choose the option you like the most and see what will happen.");
            Console.WriteLine("You also will need to answer some riddles. You have 3 guesses for each. After each wrong answer you will be given a clue.");
            Console.WriteLine("You need to score 7 points. If you answer a question on the first attempt you get 5 points, the second attempt – 3 points, and the third attempt – 1 point.");
            Console.WriteLine("If you get all the answers wrong there will be consequences.");
            Console.WriteLine("Enjoy.");
            Console.WriteLine("");
        }

        static void Game()
        {
            string playerName;
            string choice;

            Console.WriteLine("The autumn brought heavy rain and cold gusts of wind which hit the tree like a whip. You’re observing the tree branches, the way they bend because of the force of the wind, but never actually break.");
            Console.WriteLine("If only the lonely tree beside your flat wasn’t the only thing green in your neighborhood. Well, not so green anymore. The leaves of the tree have already started to change color.");
            Console.WriteLine("You wish you could get away, let the wind carry you far away from the hustle and bustle of the city.");
            Sleep(3);
            Console.WriteLine("Suddenly something odd happens.");
            Sleep(3);
            Console.WriteLine("The stranger appeared next to you. You don’t know how he could get there. He came out of nowhere.");
            Console.WriteLine("The Stranger:");
            Console.WriteLine("Hello Adventurer!");
            Console.WriteLine("What’s your name?");
            Console.WriteLine("You was staring at him blankly, completely shocked and before you know it, you told him your name.");
            Console.WriteLine("Choose nickname:");
            playerName = Console.ReadLine();
            Console.WriteLine("Nice to meet you," + playerName);
            Console.WriteLine("Are you ready for a journey?");
            Console.WriteLine("1. Wait, what are you talking about? What journey?");
            Console.WriteLine("2. How did you get here?");
            Console.WriteLine("3. Who are you?");
            Console.WriteLine("Player choice:");
            Console.ReadLine();
            Console.WriteLine("The Stranger:");
            Console.WriteLine("It doesn’t matter. What’s important is your desire to leave this place. The choice is yours. Would you like to have an adventure?");
            Console.WriteLine("1. No.");
            Console.WriteLine("2. Yes.");
            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "1":

                    {
                        Console.WriteLine("The Stranger:");
                        Console.WriteLine("Well then, the upcoming trip must wait. I hope next time we meet, you choose differently.");
                        //gameOver();
                        break;
                    }

                case "2":

                    {
                        string location;
                        Console.WriteLine("The Stranger:");
                        Console.WriteLine("Which destination do you wish to choose—a mighty mountain or a mysterious forest?");
                        Console.WriteLine("1. You choose the mighty mountain.");
                        Console.WriteLine("2. You choose the mysterious forest.");
                        location = Console.ReadLine().ToLower();

                        if (location == "1")
                        {
                            Console.WriteLine("You chose the mighty mountain.");
                            Sleep(2);
                            location1();
                        }

                        if (location == "2")
                        {
                            Console.WriteLine("You chose the mysterious forest.");
                            Sleep(2);
                            location2();
                        }


                        break;
                    }




            }





        }

        public static void location1()
        {
            string choice1;
            Console.Clear();
            Console.WriteLine("The mighty mountain.");
            Console.WriteLine("The bright light blinds you for a second. When you open your eyes, you’re standing on a high cliff.");
            Console.WriteLine("A large green meadow with numerous colorful flowers runs up and down the hill.");
            Console.WriteLine("Down below the cliff you see a lake. There aren’t any signs of autumn yet. Everything is bright and alive.");
            Console.WriteLine("The Stranger:");
            Console.WriteLine("Where do you want to go now?");
            Console.WriteLine("1. I’d like to go to the lake.");
            Console.WriteLine("2. I’d like to go somewhere higher.");
            Console.WriteLine("3. Say nothing. Jump into the lake.");

            choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "1":

                    {
                        string option;
                        Console.Clear();
                        Console.WriteLine("Walking slowly down the mountain is pleasant. You admire all kinds of lovely-looking plants.");
                        Sleep(2);
                        Console.WriteLine("After a while you reach the shore.");
                        Console.WriteLine("1. Sit down on a rock.");
                        Console.WriteLine("2. Look around.");
                        Console.WriteLine("3. Look into the water.");
                        option = Console.ReadLine().ToLower();

                        if (option == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Although you aren’t tired, you decide to sit on a nearby rock.");
                            Console.WriteLine("You take a deep breath and smile. You never thought the sound of grasshoppers could bring tears to your eyes.");
                            Console.WriteLine("But what do you know about this?");
                            Console.WriteLine("Born and raised in an industrial city, you didn’t have many opportunities to commune with nature.");
                            Sleep(2);
                        }

                        if (option == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You look around and are amazed by the beauty of the place.");
                            Console.WriteLine("You steal a glance at the stranger. The absurdity of the situation makes you laugh.");
                            Console.WriteLine("The sound of your laughter startles a flock of birds that hurry to fly away from possible danger.");
                            Console.WriteLine("You stare as they cross the sky.");
                            Console.WriteLine("Before you know it, the birds have disappeared over the horizon.");
                            Sleep(2);
                        }

                        if (option == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You look into the water and catch a glimpse of silvery fish swimming near the surface.");
                            Console.WriteLine("The water is like crystal, so clear it is.");
                            Console.WriteLine("The blue sky and cliff on which you were standing short moments ago are perfectly reflected in the water’s surface.");
                            Console.WriteLine("It is a mesmerizing view. You become lost in your thoughts.");
                            Sleep(2);
                        }

                        break;
                    }

                case "2":

                    {
                        string option;
                        Console.WriteLine("The climb is exhausting but the view waiting for you is well worth it.");
                        Console.WriteLine("The Stranger:");
                        Console.WriteLine("Do you like it?");
                        Console.WriteLine("1. Yes, definitely. It’s amazing!");
                        Console.WriteLine("2. <nod approvingly>");
                        Console.WriteLine("3. It’s nothing special.");
                        option = Console.ReadLine().ToLower();

                        if (option == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("The Stranger:");
                            Console.WriteLine("That’s good to hear.");
                            Sleep(2);
                        }

                        if (option == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("The Stranger:");
                            Console.WriteLine("You aren’t very talkative, are you?");
                            Sleep(2);
                        }

                        if (option == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("The Stranger:");
                            Console.WriteLine("You’re a terrible liar.");
                        }

                        break;
                    }

                case "3":

                    {
                        Console.WriteLine("You jump carelessly into the lake and when you’re falling, mid-jump, you remember that you can’t swim.");
                        Console.WriteLine("As you remember this, your body slices through the surface and it’s the last thing you remember.");
                        //gameOver();
                        break;
                    }

            }

            Sleep(5);
            Console.Clear();
            Console.WriteLine("The time has passed too quickly. You look up.");
            Console.WriteLine("Between the tops of the forest canopy the sky has already started to change its color to shades of red. Night is coming.");
            Console.WriteLine("The stranger:");
            Console.WriteLine("Our journey is coming to an end. You need to answer some riddles I have prepared for you if you want to go home.");
            Console.WriteLine("Here we go.");
            Sleep(2);
            riddle1();


        }
       

        public static void location2()
        {
            string choice2;
            Console.Clear();
            Console.WriteLine("The mysterious forest.");
            Console.WriteLine("The bright light blinds you for a second. When you open your eyes, you’re somewhat stunned. Across from you is a giant forest.");
            Console.WriteLine("The line of trees seems  endless. You waste no time and follow a path that leads into the woods, and into the shade of the towering trees.");
            Console.WriteLine("The calm of the forest soothes you. You find the sound of birdsong comforting.");
            Console.WriteLine("You even manage to catch a glimpse of squirrels frolicking in a pile of leaves. You also spot a small dark snake lying on a stone.");
            Console.WriteLine("Where do you want to go now?");
            Console.WriteLine("1. Come closer.");
            Console.WriteLine("2. Observe from  a distance.");
            Console.WriteLine("3. Find something more interesting.");
            choice2 = Console.ReadLine().ToLower();

            switch (choice2)
            {
                case "1":

                    {
                        Console.Clear();
                        Console.WriteLine("You decided to come closer.");
                        Console.WriteLine("The snake considers you a threat and attacks. It turns out the reptile is poisonous.");
                        Console.WriteLine("Well, that didn’t turn out so well for you! Next time you better leave wild animals alone.");

                        break;
                    }

                case "2":

                    {
                        string option;
                        Console.Clear();
                        Console.WriteLine("You decided to observe from a distance.");
                        Console.WriteLine("You observe as spots of sunlight dance on the snake’s scales.");
                        Console.WriteLine("The scale’s surface refracts light and the color turns to a beautiful iridescent green. ");
                        Console.WriteLine("It makes the snake look unique.");
                        Console.WriteLine("1. Take a photo");
                        Console.WriteLine("2. Ask the stranger what type of snake it is.");
                        option = Console.ReadLine().ToLower();

                        if (option == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose to take a photo.");
                            Console.WriteLine("You go through your pockets but can’t find your phone. It must have been left in your apartment.");
                            Console.WriteLine("Unfortunately you won’t be able to take a photo of the snake. Such a waste.");
                            Sleep(2);
                        }

                        if (option == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose to ask the stranger what type of snake it is.");
                            Console.WriteLine("The Stranger:");
                            Console.WriteLine("It’s a coluber constrictor foxii, commonly known as the blue racer.");
                            Console.WriteLine("You don’t know why you wanted information like this but it satisfies your curiosity.");
                            Sleep(2);
                        }

                        break;
                    }

                case "3":

                    {
                        string option;
                        Console.Clear();
                        Console.WriteLine("You decided to find something more interesting.");
                        Console.WriteLine("You don’t find the snake all that interesting. The squirrels are more fun—and more funny.");
                        Console.WriteLine("Maybe you will find more animals like this to look at.");
                        Console.WriteLine("1. Follow the path.");
                        Console.WriteLine("2. Step aside from the path.");
                        Console.WriteLine("3. Look up.");
                        option = Console.ReadLine().ToLower();

                        if (option == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose to follow the path.");
                            Console.WriteLine("You’re walking along the path enjoying the sound of crickets when the loud sound of a branch breaking stops you in your tracks.");
                            Sleep(4);
                            Console.WriteLine("Right in front of you a running deer crosses your path.");
                            Console.WriteLine("You only saw it for a fraction of a second, but such close contact with the large animal thrills you.");
                            Sleep(2);
                        }

                        if (option == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose to step aside from the path.");
                            Console.WriteLine("The Stranger:");
                            Console.WriteLine("You should stick to the path. You don’t want to get lost, do you?");
                            Console.WriteLine("The possibility of getting lost in the forest scares you so you decide to heed the stranger’s advice.");
                            Sleep(2);
                        }

                        if (option == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You chose to look up.");
                            Console.WriteLine("The sound of birdsong makes you look up. Exotic looking birds gaze at you with curiosity.");
                            Console.WriteLine("They’re a variety of colors and sizes. Several of them particularly catch your eye with their wonderful display of color.");
                        }

                        break;

                    }



                
            }

            Sleep(5);
            Console.Clear();
            Console.WriteLine("The time has passed too quickly. You look up.");
            Console.WriteLine("Between the tops of the forest canopy the sky has already started to change its color to shades of red. Night is coming.");
            Console.WriteLine("The stranger:");
            Console.WriteLine("Our journey is coming to an end. You need to answer some riddles I have prepared for you if you want to go home.");
            Console.WriteLine("Here we go.");
            Sleep(2);
            riddle1();
        }

        public static void riddle1()
        {

            string answer1 = "mountain";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != answer1 && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What has roots that no one sees");
                    Console.WriteLine("Is taller than the highest trees");
                    Console.WriteLine("Up, up it goes");
                    Console.WriteLine("And yet never grows");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your guess: ");
                    Console.WriteLine("");
                    guess = Console.ReadLine().ToLower();
                    guessCount++;
                    Console.Clear();

                    if (guessCount == 1)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("First hint:");
                        Console.WriteLine("You are standing on one right now.");
                    }

                    if (guessCount == 2)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("Second hint:");
                        Console.WriteLine("Oh, misty eye of the … below~");
                        Console.WriteLine("Don’t tell me you still don’t know the answer. Who doesn’t know Ed Sheeran and his song I See Fire?");
                    }


                }

                else
                {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses)
            {
                Console.WriteLine("You are out of guesses. Here comes another riddle.");
                riddle2();
            }

            else
            {
                Console.WriteLine("Great! You did it. Here comes another riddle.");
                riddle2();
            }
        }

        public static void riddle2()
        {

            string answer2 = "fish";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != answer2 && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Alive without breath");
                    Console.WriteLine("As cold as death");
                    Console.WriteLine("Never thirsty, ever drinking");
                    Console.WriteLine("All in mail never clinking");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your guess: ");
                    Console.WriteLine("");
                    guess = Console.ReadLine().ToLower();
                    guessCount++;
                    Console.Clear();

                    if (guessCount == 1)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("First hint:");
                        Console.WriteLine("There are a lot of them in the lake.");
                    }

                    if (guessCount == 2)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("Second hint:");
                        Console.WriteLine("It has gills and fins.");
                        
                    }


                }

                else
                {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses)
            {
                Console.WriteLine("You are out of guesses. Here comes another riddle.");
                riddle3();
            }

            else
            {
                Console.WriteLine("Great! You did it. Here comes another riddle.");
                riddle3();
            }
        }

        public static void riddle3()
        {

            string answer3 = "time";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != answer3 && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("");
                    Console.WriteLine("This thing all things devours");
                    Console.WriteLine("Birds, beasts, trees, and flowers");
                    Console.WriteLine("Gnaws iron, bites steel");
                    Console.WriteLine("Grinds hard stones to meal");
                    Console.WriteLine("Slays kings, ruins towns");
                    Console.WriteLine("And beats the high and mighty mountain down");
                    Console.WriteLine("");
                    Console.WriteLine("Enter your guess: ");
                    Console.WriteLine("");
                    guess = Console.ReadLine().ToLower();
                    guessCount++;
                    Console.Clear();

                    if (guessCount == 1)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("First hint:");
                        Console.WriteLine("People don’t like wasting this.");
                    }

                    if (guessCount == 2)
                    {
                        Console.WriteLine("The stranger:");
                        Console.WriteLine("Wrong answer.");
                        Console.WriteLine("Second hint:");
                        Console.WriteLine("The clock is a device that shows it.");
                    }


                }

                else
                {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses)
            {
                Console.WriteLine("You are out of guesses. It was the last riddle.");
               
            }

            else
            {
                Console.WriteLine("Great! It was the last riddle.");
                
            }
        }

        static void Sleep(int x)
        {
            Thread.Sleep(x * 1000);
        }
    }


    }
