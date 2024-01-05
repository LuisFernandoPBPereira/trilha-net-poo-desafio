namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        //Usando construtor por herança
        public Iphone(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {
            
        }
        //Sobrescrevendo o método InstalarAplicativo no Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Iphone");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}