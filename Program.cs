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
    Difficulty();   
}

void Difficulty()
{
    Console.WriteLine("Please choose a difficulty:");
    Console.WriteLine(@"
    1) Easy
    2) Medium
    3) Hard
    4) 'Free Play' ");
    int selection = Int32.Parse(Console.ReadLine());
    
    switch(selection)
    {
        case 1:
            EasyMode();
            break;
        case 2:
            MediumMode();
            break;
        case 3:
            HardMode();
            break;
        case 4:
            CheaterMode();
            break;
    }

}




void EasyMode(){
    int SecretNumber = new Random().Next(101);
    int MaxGuesses = 8;
    int RemainingGuesses = 8;
    
    Console.WriteLine("Welcome to Easy Mode! You'll have 8 guesses to guess the *secret number*!");
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

void MediumMode(){
    int SecretNumber = new Random().Next(101);
    int MaxGuesses = 6;
    int RemainingGuesses = 6;
    Console.WriteLine("Welcome to Medium Mode! You'll have 6 guesses to guess the *secret number*!");
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
void HardMode(){
    int SecretNumber = new Random().Next(101);
    int MaxGuesses = 4;
    int RemainingGuesses = 4;
    Console.WriteLine("Welcome to Hard Mode! You'll have only 4 guesses to guess the *secret number*!");
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
void CheaterMode(){
    int SecretNumber = new Random().Next(101);
    
    Console.WriteLine("Don't like the constraints of limited guessing? Here in Free Play mode you'll have unlimited guesses to guess the *secret number*!")
    Console.WriteLine("Please enter a number:");
    string UserGuessInput = Console.ReadLine();
    
    for(int i = 1; i > 0; i++){
        
       if( Int32.Parse(UserGuessInput) == SecretNumber){
        Console.Write("Congratulations! You guessed Correctly!");

       
        }
        else
        {
            if ( SecretNumber > Int32.Parse(UserGuessInput) )
            {
                Console.WriteLine("Your guess was too low.");

                Console.WriteLine("Please enter another number and try again:");
                UserGuessInput = Console.ReadLine();
              
            }
            else {
                Console.WriteLine("Your guess was too high");

        
                Console.WriteLine("Try again!:");
                UserGuessInput = Console.ReadLine();
            }
        } 
    }
    
}

