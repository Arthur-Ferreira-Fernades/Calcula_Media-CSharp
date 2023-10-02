using System;
public class Calcular {
        
    public static float nota1;
    public static float nota2;
    public static float nota3;
    public static float nota4;
    public static float resultado;
        
    public static void Main() {
         Valida1();
         Valida2();
         Valida3();
         Valida4();
         Calculo();
    }
    
    static void Valida1() {
                
        try {
                {
                 float nota1;
                 Console.WriteLine("Por favor digite a primeira nota: ");
                 nota1 = float.Parse(Console.ReadLine());
                 Calcular.nota1 = nota1;
                }
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida1();
            return;
        }
    }
    
    static void Valida2() {
        
        try {
                {
                 float nota2;
                 Console.WriteLine("Por favor digite a segunda nota: ");
                 nota2 = float.Parse(Console.ReadLine());
                 Calcular.nota2 = nota2;
                }
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida2();
            return;
        }
    }
    
    static void Valida3() {
        
        try {
                {
                 float nota3;
                 Console.WriteLine("Por favor digite a terceira nota: ");
                 nota3 = float.Parse(Console.ReadLine());
                 Calcular.nota3 = nota3;
                }
                
            }
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida3();
            return;
        }
    }
    
    static void Valida4() {
        
        try {
                {
                 float nota4;
                 Console.WriteLine("Por favor digite a quarta nota: ");
                 nota4 = float.Parse(Console.ReadLine());
                 Calcular.nota4 = nota4;
                }
                
            }
            
        catch (FormatException) {
            Console.WriteLine("Digite um valor valido, por favor.");
            Valida4();
            return;
        }
    }
    
    static void Calculo () {
       
      float resultado;
      
      resultado = (nota1+nota2+nota3+nota4)/4;
      
      Console.WriteLine("A média final do aluno é: " + resultado);

    }
   
}


