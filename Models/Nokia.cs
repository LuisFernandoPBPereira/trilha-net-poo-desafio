namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        //Usando construtor por herança
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        //Sobrescrevendo o método InstalarAplicativo no Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Nokia");
        }
    }
}