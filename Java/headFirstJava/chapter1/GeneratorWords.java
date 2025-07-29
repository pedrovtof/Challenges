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

        java.util.Random randomItemFromList = new java.util.Random();
        String space = " ";

        System.out.print(first[randomItemFromList.nextInt(first.length)]);
        System.out.print(space);
        System.out.print(second[randomItemFromList.nextInt(second.length)]);
        System.out.print(space);
        System.out.print(third[randomItemFromList.nextInt(third.length)]);

    } 
}