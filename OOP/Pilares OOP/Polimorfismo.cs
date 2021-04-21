namespace OOP.Pilares_OOP
{
    public class Liquidificador : Eletrodomestico
    {
        public Liquidificador(string nome, int voltagem) : base (nome, voltagem) { }

        public Liquidificador() : base ("Liquidificador", 220) { }

        /// <summary>
        /// Método exclusivo dessa especialização de eletrodoméstico
        /// </summary>
        private void ConfigurarVelocidade() { }

        private void TempoParaTriturarAlimento () { }

        /// <summary>
        /// Sobreescrita obrigatória de método abstrato
        /// </summary>
        public override void Ligar()
        {
            // Verifica se nenhuma velocidade está selecionada
            // Verifica energia
        }

        /// <summary>
        /// Sobreescrita obrigatória de método abstrato
        /// </summary>
        public override void Desligar()
        {
            // Volta para velocidade zero
        }

        /// <summary>
        /// Comportamento para fazer uma vitamina
        /// </summary>
        public void PrepararVitamina()
        {
            ConfigurarVelocidade();
            TempoParaTriturarAlimento();
        }

        /// <summary>
        /// Método sobreescrito atribuindo um outro comportamento sem ser o da classe base
        /// </summary>
        public override void Testar()
        {
            this.ConfigurarVelocidade();
            base.Testar();
        }
    }
}
