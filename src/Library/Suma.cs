namespace Library;
using System;
public class Suma: IEntrada{

      public int suma(int op1) {

        int x = 5; 
        int y = 10;
        int z = 15;
        op1 = (x + y + z);
            
        return op1; 

      }
}