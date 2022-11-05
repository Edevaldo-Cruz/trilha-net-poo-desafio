namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp, string proprietario, int tamanhoApp)
        {

            Console.WriteLine("=================================================================");
            Console.WriteLine($"Buscando pelo aplicativo {nomeApp} na Google Play.");
            Console.WriteLine("Aguarde por favor...");
            Thread.Sleep(2000);
            Console.WriteLine("****************************************************************");
            if (Memoria >= tamanhoApp)
            {
                Memoria = Memoria - tamanhoApp;
                Console.WriteLine("Ok, tudo ceto!!");
                Console.WriteLine($"Baixando e instalando aplicativo {nomeApp} no Nokia {Modelo}");
                Thread.Sleep(1500);
                Console.WriteLine("=================================================================");
                Console.WriteLine("Aplicativo Instalado com sucesso!");
                Console.WriteLine($"Aplicativo {nomeApp}.");
                Console.WriteLine($"Desenvolvido por: {proprietario}");
                Console.WriteLine("=================================================================");
            }
            else
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine("Memoria insuficiente!!");
                Console.WriteLine($"Para instalar o {nomeApp} é preciso de {tamanhoApp}mb disponivel.");
                Console.WriteLine($"Nokia {Modelo} tem {Memoria}mb disponivel.");
                Console.WriteLine("****************************************************************");
            }
        }
    }
}