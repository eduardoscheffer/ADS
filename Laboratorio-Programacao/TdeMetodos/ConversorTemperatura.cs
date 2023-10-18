using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

// Exercício 5: Classe ConversorTemperatura
// Classe: ConversorTemperatura
// Atributos: temperaturaCelsius
// Método: ConverterParaFahrenheit()
// Descrição: Crie um método que retorne a temperaturaCelsius convertida para Fahrenheit.

namespace TdeMetodos
{
    public class ConversorTemperatura
    {
        public ConversorTemperatura(double celciusTemperature) 
        {
            this.CelciusTemperature = celciusTemperature;
   
        }

        public double CelciusTemperature { get; set; }

        // (0 °C × 9/5) + 32
        public double ConverterParaFahrenheit() =>  (CelciusTemperature * 9/5) + 32; 
    }
}