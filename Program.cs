using rock_paper_scissors;

Console.WriteLine("Hello and welcome to a game of Rock, paper & scissors.\n");

bool playAgain = true;
bool game = true;
string player1Choice;
string player2Choice;
string yesorno;

while (playAgain)
{

    Console.WriteLine("Please, write the name of the first player: ");
    string namn1 = Console.ReadLine();
    Player player1 = new Player(namn1);

    Console.WriteLine("Please, write the name of the second player: ");
    string namn2 = Console.ReadLine();
    Player player2 = new Player(namn2);

    string firstPlayer = string.Empty;
    string secondPlayer = string.Empty;

    string[] randomPlayer = { player1.Name, player2.Name };
    Random rnd = new Random();
    int index = rnd.Next(0, randomPlayer.Length);
    firstPlayer = randomPlayer[index];

    if (firstPlayer == player1.Name)
    {
        secondPlayer = player2.Name;
    }
    else if (firstPlayer == player2.Name)
    {
        secondPlayer = player1.Name;
    }

    Console.Clear();
    Console.WriteLine("\n" + firstPlayer + " will be the starting player!\n");

    while (game)
    {
        int player1Points = 0;
        int player2Points = 0;
        while (player1Points < 3 && player2Points < 3)
        {
            player1Choice = "";
            player2Choice = "";
            while (player1Choice != "1" && player1Choice != "2" && player1Choice != "3")
            {
                Console.WriteLine(firstPlayer + ", please choose one of the following options: \n1. Rock\n2. Paper\n3. Scissors");
                player1Choice = Console.ReadLine();
                if (player1Choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine(firstPlayer + " choose: " + Input.Rock + "\n");
                }
                else if (player1Choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine(firstPlayer + " choose: " + Input.Paper + "\n");
                }
                else if (player1Choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine(firstPlayer + " choose: " + Input.Scissors + "\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please only type '1', '2' or '3'");
                }
            }

            while (player2Choice != "1" && player2Choice != "2" && player2Choice != "3")
            {
                Console.WriteLine(secondPlayer + ", please choose one of the following options: \n1. Rock\n2. Paper\n3. Scissors");
                player2Choice = Console.ReadLine();
                if (player2Choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine(secondPlayer + " choose: " + Input.Rock + "\n");
                }
                else if (player2Choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine(secondPlayer + " choose: " + Input.Paper + "\n");
                }
                else if (player2Choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine(secondPlayer + " choose: " + Input.Scissors + "\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please only type '1', '2' or '3'");
                }
            }

            switch (player1Choice)
            {
                case "1":
                    if (player2Choice == "1")
                    {
                        Console.WriteLine("It's a draw!\nNo player gets a point.");
                    }
                    else if (player2Choice == "2")
                    {
                        Console.WriteLine(secondPlayer + " won that round!");
                        player2Points++;
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                    }
                    else
                    {
                        Console.WriteLine(firstPlayer + " won that round!");
                        player1Points++;
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                    }
                    break;
                case "2":
                    if (player2Choice == "1")
                    {
                        Console.WriteLine(firstPlayer + " won that round!");
                        player1Points++;
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                    }
                    else if (player2Choice == "2")
                    {
                        Console.WriteLine("It's a draw!\nNo player gets a point.");
                    }
                    else
                    {
                        Console.WriteLine(secondPlayer + " won that round!");
                        player2Points++;
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                    }
                    break;
                case "3":
                    if (player2Choice == "1")
                    {
                        Console.WriteLine(secondPlayer + " won that round!");
                        player2Points++;
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                    }
                    else if (player2Choice == "2")
                    {
                        Console.WriteLine(firstPlayer + " won that round!");
                        player1Points++;
                        Console.WriteLine(firstPlayer + " currently has " + player1Points + " points.\n");
                        Console.WriteLine(secondPlayer + " currently has " + player2Points + " points.\n");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!\nNo player gets a point.");
                    }
                    break;
            }
        }
        if (player1Points == 3)
        {
            Console.Clear();
            Console.WriteLine("Congratulations " + firstPlayer + "! You won the game.\n");
            Console.WriteLine("The final score was: " + player1Points + " - " + player2Points);
            game = false;
        }
        if (player2Points == 3)
        {
            Console.Clear();
            Console.WriteLine("Congratulations " + secondPlayer + "! You won the game.");
            Console.WriteLine("The final score was: " + player2Points + " - " + player1Points);
            game = false;
        }
    }
    while (!game)
    {
        Console.WriteLine("\nDo you want to play the game again?\nType Y for YES and N for NO");
        yesorno = Console.ReadLine();

        if (yesorno.ToUpper() == "Y")
        {
            Console.Clear();
            game = true;
        }
        else if (yesorno.ToUpper() == "N")
        {
            Console.Clear();
            game = true;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please only type either 'Y' or 'N'");
        }
    }
}

Console.WriteLine("Thank you for playing!");