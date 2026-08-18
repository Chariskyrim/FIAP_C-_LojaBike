using LojaBike;

Console.WriteLine("********************************* SISTEMA DA LOJA DE BIKE ELÉTRICA*******************");
Console.WriteLine();

//INSTANCIAR OBJETO DA CLASSE BIKE

Bike bike = new Bike();

Console.Write("Modelo Bike: ");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capacidade da Bateria: ");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso do Ciclista: ");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade de Cargas Estimada por Mês : ");
bike.RecargaMes = int.Parse(Console.ReadLine());

// EXIBIR NA TELA O RESULTADO
Console.WriteLine("\n----------RELATÓRIO DE DESEMPENHO DA BIKE------------");
Console.WriteLine($"Nome Bicicleta: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada: {bike.CalcularAutonomia():F1}Km por Carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal():F2}KWm");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal():N2}R$");
Console.WriteLine($"A Bike é Econômica: {bike.ModeloEconomico()}");
