namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria, string imei)
            : base(numero, modelo, memoria, imei)
        {
        } 
        
        public override void InstalarAplicativo(string nomeApp){
            // TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instale o APP {nomeApp} pela playstore");
    }
}
}