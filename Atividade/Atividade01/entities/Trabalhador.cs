using System.Collections.Generic;
using Atividade1.Entities.Enums;

namespace Atividade1.Entities
{
    public class Trabalhador
    {
        public string Nome { get; private set; }
        public NivelProfissional Nivel { get; private set; }
        public decimal BaseSalario { get; private set; }
        public Departamento Departamento { get; private set; } // Associa o trabalhador a um departamento
        public List<ContratoHoras> Contratos { get; private set; } = new List<ContratoHoras>(); // Lista de contratos do trabalhador

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelProfissional nivel, decimal baseSalario, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoHoras contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHoras contrato)
        {
            Contratos.Remove(contrato);
        }

        public decimal Renda(int mes, int ano)
        {
            decimal total = BaseSalario;

            foreach (ContratoHoras contrato in Contratos)
            {
                // Verifica se o contrato é do mês e ano especificados
                if (contrato.Data.Month == mes && contrato.Data.Year == ano)
                {
                    total += contrato.ValorTotal();
                }
            }

            return total;
        }
    }
}