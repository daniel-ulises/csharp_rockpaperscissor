class Program
{
    static void Main(String[] args)
    {
        
        String[] rps = {"rock", "paper", "scissor"};
        Random random = new Random();
        bool game = true;

        Console.WriteLine("Let's play a game of Rock Paper Scissor. The first one to win 5 rounds wins the game.");
        Console.WriteLine("How to play: when asked just type r (Rock), p (Paper) or s (Scissor). Other input will be ignored.");
        while (game)
        {
            int playerScore = 0;
            int computerScore = 0;
            
            while(playerScore < 5 && computerScore < 5)
            {
                String compChoice = rps[random.Next(1, 3)];

                Console.WriteLine("\n(r)ock, (p)aper or (s)cissor?");
                String playerChoice = Console.ReadLine();

                if(!(playerChoice == "r" || playerChoice == "p" || playerChoice == "s"))
                {
                    Console.WriteLine("Stop being stupid, I told you to just write r, p or s. Try again.");
                }


                if(playerChoice.ToLower() == "r")
                {
                    playerChoice = "rock";
                }else if (playerChoice.ToLower() == "p")
                {
                    playerChoice = "paper";
                }else if (playerChoice.ToLower() == "s")
                {
                    playerChoice = "scissor";
                }

                switch (playerChoice)
                {
                    case "rock":
                        switch (compChoice)
                        {
                            case "rock":
                                Console.WriteLine(String.Format("It's a tie! You both played {0}", compChoice));
                                break;
                            case "paper":
                                Console.WriteLine(String.Format("You played {0} against the computer's {1}. You lose this round.", playerChoice, compChoice));
                                ++computerScore;
                                break;
                            case "scissor":
                                Console.WriteLine(String.Format("You player {0} against the computer's {1}. You win this round.", playerChoice, compChoice));
                                ++playerScore;
                                break;
                        }
                        break;

                    case "paper":
                        switch (compChoice)
                        {
                            case "rock":
                                Console.WriteLine(String.Format("You player {0} against the computer's {1}. You win this round.", playerChoice, compChoice));
                                ++playerScore;
                                break;
                            case "paper":
                                Console.WriteLine(String.Format("It's a tie! You both played {0}", compChoice));
                                break;
                            case "scissor":
                                Console.WriteLine(String.Format("You played {0} against the computer's {1}. You lose this round.", playerChoice, compChoice));
                                ++computerScore;
                                break;
                        }
                        break;

                    case "scissor":
                        switch (compChoice)
                            
                        {
                            case "rock":
                                Console.WriteLine(String.Format("You played {0} against the computer's {1}. You lose this round.", playerChoice, compChoice));
                                ++computerScore;
                                break;
                            case "paper":
                                Console.WriteLine(String.Format("You player {0} against the computer's {1}. You win this round.", playerChoice, compChoice));
                                ++playerScore;
                                break;
                            case "scissor":
                                Console.WriteLine(String.Format("It's a tie! You both played {0}", compChoice));
                                break;
                        }
                        break;

                }

                Console.WriteLine("\n*------- SCORE -------*");
                Console.WriteLine(String.Format("Player: {0} *---* Computer: {1}\n", playerScore, computerScore));

            }

            if(playerScore > computerScore)
            {
                Console.WriteLine(String.Format("You win by {0} rounds!", playerScore - computerScore));
            }
            else if(playerScore < computerScore)
            {
                Console.WriteLine(String.Format("You lose by {0}. Better luck next time!", computerScore - playerScore));
            }

            Console.WriteLine("Do you want to play again? [y/n]");
            String response = Console.ReadLine();

            if(response.ToLower() == "y" || response.ToLower() == "yes")
            {
                game = true;
            }
            else
            {
                game = false;
            }
        }

        Console.WriteLine("Thanks for playing! See you next time.");
    }
}