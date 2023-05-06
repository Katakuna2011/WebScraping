using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Classes
{
    public class Item
    {
        public string Identificador { get; }

        public string Multiplicador { get; set; }

        decimal _probabilidade;
        public decimal Probabilidade { get { return _probabilidade; } set { _probabilidade = _probabilidade / 100; } }

        int _porcentagem;
        public int Porcentagem { get { return _porcentagem; } set { _porcentagem = (int)Probabilidade * 100; } }

        DateTime _dataEHora;
        public DateTime DataEHora { get { return _dataEHora; } set { _dataEHora = DateTime.Now; } }

        public Item()
        {
            Identificador = Guid.NewGuid().ToString().Substring(0, 6);
        }

        public override string ToString()
        {
            return $"========== Blaze Crash ==========\n" +
                $">>>> Crash atual: {Multiplicador}\n" +
                $">>>> Probabilidade atual: {Probabilidade} - {Probabilidade * 100}/100\n" +
                $">>>> Porcentagem: {Porcentagem}%\n" +
                $">>>> Data e hora: {DataEHora}\n";
        }
    }
}