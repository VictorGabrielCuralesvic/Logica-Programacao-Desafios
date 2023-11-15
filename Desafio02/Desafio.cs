using System;

public class Desafio
{
    public static void Main()
    {
        float valorSalario = float.Parse(Console.Readline());
        float valorBeneficios = float.Parse(Console.Readline());

        float valorImpost = 0;

        if (valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImpost = 0.05F * valorSalario;
        } 
        else if (valorSalario>= 1100 && valorSalario <= 2500)
        {
            valorImpost = 0.10F * valorSalario;
        }
        else {
            valorImpost = 0.15F * valorSalario;
        }

        float saida = (valorSalario - valorImpost) + valorBeneficios;
        Console.WriteLine(saida.ToString("0.00"));

    }
}