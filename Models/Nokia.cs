namespace DesafioPOO.Models
{
    // TODO: IMPLEMENTADO!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public string App {get; set;}
        // TODO: IMPLEMENTADO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            App = nomeApp;
            Console.WriteLine($"Instalando o aplicativo '{App}' no Nokia");
        }
    }
}