namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Olá, bem vindo de volta...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Recruiter Pottencial Ligando....");
            Console.WriteLine("*****************************");
        }

        public abstract void InstalarAplicativo(string nomeApp, string proprietario, int tamanhoApp);
    }
}