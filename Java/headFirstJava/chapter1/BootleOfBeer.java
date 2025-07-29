// Must writer a programming for sing the son 99Bottles of Beer


public class BootleOfBeer{

    public static void main (String[] args){

        int i = 99;

        String song  = "green bottles hanging on the wall";
        String song2 = "And if one green bottles should accidentally fall";

        while (i >= 0){

            if (i==1){
                song  = "green bottle hanging on the wall";
            }

            else if (i==0){
                System.out.println("There'll be no green boottles, hanging on the wall");
                break ;
            }

            System.out.println(i+" "+song);
            System.out.println(i+" "+song);
            System.out.println(song2);

            i -= 1;
        }

    }
}

