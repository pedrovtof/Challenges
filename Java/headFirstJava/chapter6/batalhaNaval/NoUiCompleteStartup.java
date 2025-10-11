import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

class StartupBust {
	
		/*
		*
		* INSTANCES VAR
		*
		*/
	
		private String helper;
		private ArrayList<ArrayList<String>> startups;
		private int numOfGuess;


		/*
		*
		* CUSTOM PUBLIC METHODS
		*
		*/


		
		public ArrayList<ArrayList<String>> setUpGames(){
			
			Random aNumber = new Random();
			ArrayList<ArrayList<String>> matrix = new ArrayList<ArrayList<String>>();
			int numberOfStartups = aNumber.nextInt(5) + 1;
			
			int i = 0;
			
			while(i<numberOfStartups){
				
				int  	size 	 	= aNumber.nextInt(7); 							   	// THIS SET THE SIZE
				char 	high 	 	=  (char) ('a' + aNumber.nextInt('g' - 'a' + 1));  	// THIS SET IF THE HIGH
				int 	isColumn 	= aNumber.nextInt(2); 							   	// THIS SET IF THE POSITION IS TO UP OR TO DOWN
				boolean exists 		= false;										   	// THIS TRY TO FIND A TARGET THAT ALREADY EXISTS
				int 	volume 		= aNumber.nextInt(4) + 1;						   	// THIS SET THE MAX NUMBER OF SIZE
				
				if(matrix.size() >0){
					for(int x=0;x< matrix.size(); x++){ 							   	// VALIDATE IF ALREADY EXISTS AND SET
						exists = matrix.get(x).contains(Integer.toString(size) + Character.toString(high)); 
						if(exists == true){ 
							break;
						}; 
					}
				}
				
				if(exists == false){ 	// IF NOT EXISTS CREATE AND ADD 1 TO INDEX
					matrix.add(new ArrayList<String>());
					
					if(isColumn == 1){
						for(int x=0;x<volume;x++){
							matrix.get(i).add(Integer.toString(size + x) + Character.toString(high + x));
						}
					}
					if(isColumn == 0){
						for(int x=0;x<volume;x++){
							matrix.get(i).add(Integer.toString(size + x) + Character.toString(high));
						}
					}

					i++;
				}
				
				//System.out.println(size + " - "+ high + " - "+ exists + " - "+isColumn);
					
			}
			
			System.out.println("Number of targets - "+numberOfStartups+" Columns go from A to G and the max size of startup is 6");
			
			
			setStartups(matrix);
			
			return matrix;
			
		}
		
		public void startPlaying(){
			
			Scanner userInput = new Scanner(System.in);
			boolean endGame = false;
			
			
			while (true){
				
				setNumOfGuess(getNumberOfGuess() + 1);
				System.out.print("Your guess :");
				String userGuess = userInput.nextLine();
				setHelper(userGuess);
				checkUserGuess();
				endGame = finishGame();
				
				
				if(endGame == true){
					break;
				}
				
			}
			
			return;
		}
		
		private void checkUserGuess(){
			
			String  guess = getHelper();
			boolean miss  = true;
			
			
			for(int i=0;i<getStartups().size();i++){
				if(getStartups().get(i).contains(guess) == true){
					System.out.println("you hit!");
					getStartups().get(i).remove(guess);
					
					if(getStartups().get(i).size() == 0){
						System.out.println("OMGG u kill that last one UHUU");
					}
					miss = false;
					
					//System.out.println("COLA => "+getStartups() + " -- "+getStartups().size());
					break;
					
				}
			}
			
			if(miss == true){
				System.out.println("OPS!!! Someone miss the target LOL HAHAHA");
				//System.out.println("COLA => "+getStartups());
			}
			
			return;
		}
		
		private boolean finishGame(){
			
			boolean isFinish = false;
			
			getStartups().removeIf(l -> l.isEmpty());
			
			
			if(getStartups().size() == 0){
				isFinish = true;
				System.out.println("OPS, end of the game"+" - Number of guess -> "+getNumberOfGuess());
			}
			
			
			return isFinish;
		}


		/*
		*
		* GETTERS AND SETTERS
		*
		*/

		public void setHelper(String props){
			helper = props;
		}

		public String getHelper(){
			return helper;
		}
		
		public void setStartups(ArrayList<ArrayList<String>> props){
			startups = props;
		}
		
		public ArrayList<ArrayList<String>> getStartups(){
			return startups;
		}
		
		public void setNumOfGuess(int props){
			numOfGuess = props;
		}
		
		public int getNumberOfGuess(){
			return numOfGuess;
		}
}

class StartupBustTestDriver{
	
		public static void main(String [] args){
			
			// Genareta startups
				// Save the position of startups
			
			
			ArrayList<ArrayList<String>> entity = new ArrayList<ArrayList<String>>();
			
			StartupBust game = new StartupBust();
			entity = game.setUpGames();
			
			System.out.println("RESPOSTA "+entity);
			
			
			// Start the game 
			game.startPlaying();
			
				// Acept info in the console
				// awyas validate user guess
				// If guess is right, try to remove from array that item
				// if there is no more itens in the array, end the game
			
			// Finish the game
			
		}
	
}
