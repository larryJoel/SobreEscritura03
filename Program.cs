class Program{
    static void Main(string[] args){
        Program prog = new Program();
        var sumaEnteros =  prog.Sumar(3,8);
        var sumaTexto = prog.Sumar("Hola"," Mundo");
        var sumaReales = prog.Sumar(2.15,15.254);
        Console.WriteLine("Sumando enteros: "+sumaEnteros);
        Console.WriteLine("Suma reales: "+ sumaReales);
        Console.WriteLine("Suma texto: "+sumaTexto);
    }

    int Sumar(int num1, int num2){
        int suma;
        suma = num1+num2;
        return suma;
    }
    string Sumar(string a, string b){
        return a+b;
    }
    double Sumar(double num1, double num2){
        double suma;
        suma = num1+num2;
        return suma;
    }
}
