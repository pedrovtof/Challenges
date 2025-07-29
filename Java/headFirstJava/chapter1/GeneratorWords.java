// Create a program capable of generating words.

// 1 - Create 3 String list
// 2 - Verify the length of each list
// 3 - generate 3 random numbers
// 4 - Create a phrase using the random numbers and the lists
// 5 - Show the phrase

import java.util.*;

public class GeneratorWords{

    public static void main(String[] args){

        String[] first = {
            "Like",
            "Hate",
            "Love",
            "Think a lot of",
            "Don't understand"
        };
        String[] second = {
            "Naruto",
            "One Piece",
            "Pokemon",
            "Demon Slayer",
            "Konosuba",
            "HunterXHunter"
        };
        String[] third = {
            "movies",
            "first episode",
            "last episode",
            "main character",
            "antagonist"
        };

        int lenFirstList = first.length;
        int lenSecondList= second.length;
        int lenThirdList = third.length;

        java.util.Random randomItemFromList = new java.util.Random();

        int i   = 0;
        int x   = randomItemFromList.nextInt(lenFirstList);
        int y   = randomItemFromList.nextInt(lenSecondList);
        int z   = randomItemFromList.nextInt(lenThirdList);

        String space = " ";

        System.out.println(first[x]+space+second[y]+space+third[z]);

    } 
}