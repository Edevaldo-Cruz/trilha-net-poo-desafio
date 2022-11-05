namespace trilha_net_poo_desafio.Models
{
    public class App
    {
        public string NomeApp { get; set; }
        public string Proprietario { get; set; }
        public int TamanhoApp { get; set; }


        public App(string nomeApp, string proprietario, int tamanhoApp)
        {
            NomeApp = nomeApp;
            Proprietario = proprietario;
            TamanhoApp = tamanhoApp;
        }
    }



}