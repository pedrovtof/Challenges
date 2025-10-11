


public class PoolPuzzleFour {

    public static void main(String[] args){
        Value [] values = new Value[6]; //
        int number = 1;
        int i=0;

        while(i<6){
            values[i] = new Value(); //
            values[i].intValue=number; //
            number = number * 10;
           i = i+1;  //
        }

        int result = 0;
        i = 6;
        
        while(i>0){
            i = i-1; //
            result = result + values[i].doStuff(i); //
        }

        System.out.println("result "+result);
    }

}

class Value{ //
    int intValue;

    public int doStuff(int factor){ //
        if (intValue>100){
            return intValue * factor; //
        } else {
            return intValue * (5- factor); //
        }
    }
}


/*


public class PoolPuzzleFourTestDriver {

    public static void main(String[] args){
        __
        int number = 1;
        int i=0;

        while(i<6){
            __
            __
            number = number * 10;
            __
        }

        int result = 0;
        i = 6;
        
        while(>0){
            __
            result = result + ___;
        }

        System.out.println("result "+result);
    }

}

public class __{
    int intValue;

    __ __ doStuff(int __){
        if (intValue>100){
            return __ ;
        } else {
            return __;
        }
    }
}

*/