using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 4: Classe Concatenador
// Classe: Concatenador
// Métodos: Sobrecargas do método Concatenar()
// Descrição: Crie sobrecargas do método Concatenar como especificado previamente, sem utilizar atributos.

namespace TdeMetodos
{
    public class Concatenador
    {
        public static string Concatenar(params string[] args) => string.Concat(args);
    }
}