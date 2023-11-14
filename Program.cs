// See https://aka.ms/new-console-template for more information

int[] numeros = { 1, 2, 3, 4, 5 };


/*
    Sintaxis 1:
    * De Metodos o Lambda.
*/
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();


Console.WriteLine(numerosPares);
