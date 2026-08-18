namespace LojaBike
{
    class Bike
    {
        //DECLARAÇÕES
        public string Modelo { get; set; } = string.Empty;
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }

        //MÉTODOS
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool pesoElevado = PesoCiclista > 90.0;
            //SE O PESO FOR ACIMA DE 90KH, A BATERIA REDUZ PARA 15% DE AUTONOMIA
            return pesoElevado ?(autonomiaBase * 0.05) : autonomiaBase; //Estrutura condicional (If = ?, Else = :)

        }

        public double CalcularConsumoMensal()
        {
            double kmPorCarga = Bateria / 1000.00;
            return kmPorCarga * RecargaMes;

        }

        public double CalcularCustoMensal()
        {
            const double PRECO_KWH = 0.80; // Preço do kWh em reais
            return CalcularConsumoMensal() * PRECO_KWH;
        }

        public bool ModeloEconomico()
        {
            return (CalcularCustoMensal() < 15.00) || (CalcularAutonomia() > 40.0);
        }
    }
}
