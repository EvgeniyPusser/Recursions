void Main()
{
  Console.Write($"1, 2 \n");
  Fibbo(11, 20);
}

 void Fibbo(int a, int b){
    
    if(b > 300){
        
        return;
    }
    b = a + b;
   
    a = b - a;
 //Console.Write(a + "  ");
    
//  Console.Write(b + "  ");
    // b = a + b;
    //  Console.Write(a);
    Console.Write($"{b}  ");
    // //Console.Write($"{a},\t {b}");
    Fibbo(a , b);
    
  }
  //  Console.Write($"1, 2 \n");
  // Fibbo(11, 20);
 
   Main(); 



