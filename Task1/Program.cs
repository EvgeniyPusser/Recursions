// double Factorial(double n){
//     if(n == 1){
//         return 1;}

    
//     return n * Factorial(n - 1); 
    
// }

//Console.Write(Factorial(5));


void OpenMatrioshka(int size){
    if(size == 1){
        return;
    }
    OpenMatrioshka(size - 1);
    Console.WriteLine($"Open Matryioshla of size {size}...");
   
}OpenMatrioshka(7);