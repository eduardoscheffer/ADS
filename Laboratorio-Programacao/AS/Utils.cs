using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS
{
    public class Utils
    {
        public static string GetMenu()
        {
            StringBuilder menu = new StringBuilder(); // Metodo estatico que cria uma string como sendo o Menu de um programa qualquer

            menu.Append("1 - Adicionar Livro");
            menu.Append("   2 - Encontrar Livro");
            menu.Append("   3 - Remover Livro");
            menu.Append("   \u001b[31m0 - Sair\u001b[0m");

            return menu.ToString();
        }
    }
}