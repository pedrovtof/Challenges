import java.util.Random;
import java.util.Scanner;

public class SimpleStartup {
    private int [] locationsCells;
    private int numOfHits;
    private int numOfGuess;

    public String checkYourSelf(int guess){

        String result = "miss";
        
        int hits 			= getNumberOfHits();
        int currentGuess 	= getNumberOfGuess();
		
        setNumberOfGuess(currentGuess + 1);

        for(int cell : locationsCells){

            if(guess == cell){
                
                result = "hit";
                hits++;
                setNumberOfHits(hits);
                break;   
            }

        }     

        if(hits == locationsCells.length){
            result = "kill";
        }
   

        System.out.println(result);

        return result;

    }

    public void setLocationCells(int [] loc){
        locationsCells = loc;
    }

    public int [] getLocationCells(){
        return locationsCells;
    }

    public void setNumberOfHits(int hits){
        numOfHits = hits;
    }

    public int getNumberOfHits(){
        return numOfHits;
    }

    public void setNumberOfGuess(int hits){
        numOfGuess = hits;
    }

    public int getNumberOfGuess(){
        return numOfGuess;
    }


}

class SimpleStartupTestDriver{

    public static void main(String[] args){
        SimpleStartup dot = new SimpleStartup();
        Random randomNum  = new Random();

        int[] locations={randomNum.nextInt(3) + 1,randomNum.nextInt(3) + 4, randomNum.nextInt(3) + 7};

        System.out.println(locations[0]);
        System.out.println(locations[1]);
        System.out.println(locations[2]);

        dot.setLocationCells(locations);
        dot.setNumberOfHits(0);

        Scanner userInputGuess = new Scanner(System.in);
        
        while(true){

            System.out.print("Enter a number: ");
            int userGuess = userInputGuess.nextInt();

            String result = dot.checkYourSelf(userGuess);

            if(result.equals("kill")){
                System.out.print("Total guess: "+ dot.getNumberOfGuess());
                System.out.print(" - "+"Total hits: "+ dot.getNumberOfHits());
                break;
            }
            
        }

    }

}