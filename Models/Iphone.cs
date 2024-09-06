namespace DesafioPOO.Models
{
    // TODO: IMPLEMENTADO!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
         string App { get; set; }
        // TODO: IMPLEMENTADO!!
        public override void InstalarAplicativo(string nome)
        {
            App = nome;
            Console.WriteLine($"Instalando o aplicativo '{App}' no Iphone");
            
        }
    }
}