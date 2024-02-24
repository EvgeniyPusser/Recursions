

//Factorial(5);


double Factorial(double n){
    if(n == 1){
        return 1;}

    
    return n * Factorial(n - 1); 
    
}Console.Write(Factorial(50));
//Console.Write(Factorial(5));
