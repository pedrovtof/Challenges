class Sailboat { //
    
    private int lentgh ; //
    public void setLength(int len){ // // //
        lentgh = len;
    }

    public int getLength(){
        return lentgh; // //
    }

    public void move() { //
        System.out.print("hoist sail "); //
    }

}

class Boat{ //

    public void move (){ // //
        System.out.print("drift "); //
    }

}

class Rowboat extends Boat { // //
    
    public void rowTheBoat(){ //
        System.out.print("stroke natasha");
    }

}

class TestBoats {
    
    public static void main(String [] args){ // // //
        Boat b1 = new Boat(); //
        Sailboat b2 = new Sailboat(); //
        Rowboat b3 = new Rowboat(); //
        b2.setLength(32);
        b1.move(); //
        b3.move(); //
        b2.move(); //
    }

}

