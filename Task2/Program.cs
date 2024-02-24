 void Fibbo(int a, int b){
  //Console.Write($" {b}");
    if(b > 30){
        return;
    }
    b = a + b;
   
    a = b - a;
 //Console.Write(a + "  ");
    
//  Console.Write(b + "  ");
    // b = a + b;
    //  Console.Write(a);
    Console.Write($"{b}  ");пше фвв
    // //Console.Write($"{a},\t {b}");
    Fibbo(a , b);
    
  }
   Console.Write($"1, 2");
  Fibbo(1,2);
 
    



