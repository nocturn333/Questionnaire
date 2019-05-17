using System;

class GuessingGame {
  public static void Main (string[] args) {
	
	//set a random number
    int num = new Random().Next( 1, 10);
	//set number of guesses left
	int guessLeft = 3;
    string val;

    //Console.WriteLine("The number is "+num);

	do{
		//show how many guesses are left
		Console.WriteLine("Guesses left: "+ guessLeft);
		//prompt the user to enter a guess
		Console.Write("Enter guess: ");
		//user enters his guess
        val = Console.ReadLine();
		
		//convert the input to integer
   		int guess = Convert.ToInt32(val);
		
		if(guess!=num){
			//tell the user his guess was wrong
			Console.WriteLine("Wrong");
			//reduce the guesses left by one
			guessLeft--;
        }
		else{
			//tell the user he was successful and exit the loop
			Console.WriteLine("You win");
			break;
		}
	}while(guessLeft>0
	
	//tell the user he was unsuccessful
	if(guessLeft<=0){
		Console.WriteLine("You lose");
		//show what the correct number was
		Console.WriteLine("The number is "+num);
	}
  }
}