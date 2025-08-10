// resolve the puzzle of the book / page 43

class Drumkit{

    boolean tophat = true;
    boolean snare = true;

    void playtophat(){
        System.out.println("ding-ding da-ding");
    }

    void playshare(){
        System.out.println("bang bang ba-bang");
    }
}

class DrumkitTestDriver{

    public static void main(String[] args){

        Drumkit d = new Drumkit();

        d.playshare();
        d.playtophat();

        d.snare = false;

        if(d.snare == true){
            d.playshare();
        }

    }
}