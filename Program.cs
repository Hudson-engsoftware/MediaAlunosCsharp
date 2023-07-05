using System;
using System.Globalization;

namespace TerceiroPrograma;

class Alunos{

    public static void Main(string[]args){

        Alunos aluno = new Alunos();


        Console.WriteLine("Nome do Aluno : ");
        Console.WriteLine("Nota 1 :");
        aluno.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Nota 2 :");
        aluno.nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Nota 3 :");
        aluno.nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine("Nota Final :");
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture);

            if (aluno.Aprovado()) {
Console.WriteLine("APROVADO");
}else {
                Console.WriteLine("REPROVADO");}

        Console.WriteLine("FALTARAM "
            + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            + " PONTOS");
}       
}



