using System;

Main();


void Main()
{
    Console.Write("WELCOME..To...The...Guessing Game!!!!");
    Console.WriteLine(@"
    .
    ..
    ...
    ....
    ...
    ..
    .");
    Console.Write("To play simply type a number when told to. You only have 4 chances to guess correctly.");
    Console.WriteLine(@"
    .
    ..
    ...
    ....
    ...
    ..
    .");

   
    //Ask for & display user's guess 
    UserGuess();   
}

void UserGuess(){
    int SecretNumber = new Random().Next(101);
    int MaxGuesses = 4;
    int RemainingGuesses = 4;
    
    Console.WriteLine("Please enter a number:");
    string UserGuessInput = Console.ReadLine();
    
    for(int i = 1; i < MaxGuesses; i++){
        
       if( Int32.Parse(UserGuessInput) == SecretNumber){
        Console.Write("Congratulations! You guessed Correctly!");

       
        }
        else
        {
            if ( SecretNumber > Int32.Parse(UserGuessInput) )
            {
                Console.WriteLine("Your guess was too low.");

                RemainingGuesses--;
                Console.WriteLine($"You guessed...poorly and have {RemainingGuesses} guesses remaining.");
                Console.WriteLine("Please enter another number:");
                UserGuessInput = Console.ReadLine();
              
            }
            else {
                Console.WriteLine("Your guess was too high");

                RemainingGuesses--;
                Console.WriteLine($"You guessed...poorly and have {RemainingGuesses} guesses remaining.");
                Console.WriteLine("Please enter another number:");
                UserGuessInput = Console.ReadLine();
            }
        } 
    }
    
}

