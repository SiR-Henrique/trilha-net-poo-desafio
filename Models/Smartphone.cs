namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        // COMPLETO: TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo { get; set; } 

        private string Imei { get; set; } 

        private int Memoria { get; set; } 
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // COMPLETO: TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = Modelo;
            Imei= imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}