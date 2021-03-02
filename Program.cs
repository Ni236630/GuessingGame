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
    Console.Write("To play simply type a number when told to.");
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
    Console.WriteLine("Please enter a number:");
    string UserGuessInput = Console.ReadLine();
    Console.WriteLine($"Your guess was: {UserGuessInput}");
}