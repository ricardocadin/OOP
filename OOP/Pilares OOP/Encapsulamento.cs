namespace OOP.Pilares_OOP
{
    public class Encapsulamento
    {
        public string PrepararVitamina()
        {
            var liquidificador = new Liquidificador();

            liquidificador.Ligar();
            liquidificador.PrepararVitamina();
            liquidificador.Desligar();

            return "Vitamina pronta!";
        }
    }
}
