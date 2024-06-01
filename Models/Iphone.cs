namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // * IMPLEMENTADO *
    public class Iphone : Smartphone
    {
        // Adicionado Construtor vindo da Classe abstrata Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
         
        // TODO: Sobrescrever o método "InstalarAplicativo" 
        // * IMPLEMENTADO *
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}