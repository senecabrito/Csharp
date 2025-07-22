namespace Teste17.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta co1 = new Conta(1, "João", 1000);
            ContaEmpresarial ce1 = new ContaEmpresarial(2, "Nozama LTDA", 5000, 20000);
            ContaPoupanca cp1 = new ContaPoupanca(3, "Maria", 2000, 5);

            // UPCASTING
            Conta co2 = ce1; // ContaEmpresarial é uma Conta, então podemos fazer isso
            Conta co3 = cp1; // ContaPoupanca é uma Conta, então também podemos fazer isso
            Conta co4 = new ContaEmpresarial(4, "Empresa X", 10000, 5000);
            Conta co5 = new ContaPoupanca(5, "Poupança Y", 3000, 3);

            // DOWNCASTING
            ContaEmpresarial ce2 = (ContaEmpresarial)co2; // Downcasting de Conta para ContaEmpresarial
            ContaEmpresarial ce3 = co2 as ContaEmpresarial; // Downcasting seguro usando 'as'
            ContaPoupanca cp2 = (ContaPoupanca)co3; // Downcasting de Conta para ContaPoupanca
            ContaPoupanca cp3 = co3 as ContaPoupanca; // Downcasting seguro usando 'as'

            // Verificação de tipo antes do downcasting
            if (co5 is ContaPoupanca)
            {
                ContaPoupanca cp4 = (ContaPoupanca)co5; // Downcasting seguro com verificação de tipo usando 'is'
            }

        }
    }
}