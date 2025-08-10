// resolve the JigSaw puzzle of the book / page 44

class Echo {
    
    int count = 0;
    void Hello(){
        System.out.println("Helloooo...");
    }
}


public class EchoTestDrive {
    public static void main(String[] args){
        Echo e1 = new Echo();
        Echo e2 = new Echo();
        int x = 0;
        while(x<4){
            e1.Hello();
            e1.count = e1.count + 1;
            if(x>0){
                e2.count = e2.count + 1;
            }
            if (x>1){
                e2.count = e2.count + e1.count;
            }
            x = x + 1;
        }
        System.out.println(e2.count);
    }
}



/*


public class ____ {
    
    int ____ = 0;
    void ____ {
        System.out.println("Helloooo...");
    }
}


public class EchoTestDrive {
    public static void main(String[] args){
        Echo e1 = new Echo();
        ____
        int x = 0;
        while(____){
            e1.hello();
            ____
            if(____){
                e2.count = e2.count + 1;
            }
            if (____){
                e2.count = e2.count + e1.count;
            }
            x = x + 1;
        }
        System.out.println(e2.count);
    }
}
*/