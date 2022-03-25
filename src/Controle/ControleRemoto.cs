namespace Aula6.Controle
{


    public class ControleRemoto : Controlador
    {
        private int volume;
        private bool ligado;
        private bool tocando;

        public ControleRemoto() : base()
        {
            this.volume = 50;
            this.ligado = false;
            this.tocando = false;
        }

        private int getVolume()
        {
            return this.volume;
        }
        private bool getLigado()
        {
            return this.ligado;
        }
        private bool getTocando()
        {
            return this.tocando;
        }
        private void setVolume(int v)
        {
            this.volume = v;
        }
        private void setLigado(bool l)
        {
            this.ligado = l;
        }
        private void setTocando(bool t)
        {
            this.tocando = t;

        }

        public void ligar()
        {
            this.setLigado(true);
        }
        public void desligar()
        {
            this.setLigado(false);
        }
        public void abrirMenu()
        {
            Console.WriteLine("------Menu------");
            Console.WriteLine("Está ligado?" + this.getLigado());
            Console.WriteLine("Está tocando?" + this.getVolume());
            Console.Write("Volume: " + this.getVolume());
            for (int i = 0; i <= this.getVolume(); i += 10)
            {
                Console.WriteLine(" * ");
            }

        }
        public void fechaMenu()
        {
            Console.WriteLine("fechando Menu");
        }
        public void maisVolumeMenu()
        {
            if (this.getLigado())
            {
                this.setVolume(this.getVolume() + 5);
            }

        }
        public void menosVolumeMenu()
        {
            if (this.getLigado())
            {
                this.setVolume(this.getVolume() - 5);
            }
            else
            {
                Console.WriteLine("Impossivel diminuir volume");
            }
        }
        public void ligarMudo()
        {
            if (this.getLigado() && this.getVolume() > 0)
            {
                this.setVolume(0);
            }
        }
        public void desligarMundo()
        {
            if (this.getLigado() && this.getVolume() == 0)
            {
                this.setVolume(50);
            }
        }
        public void play()
        {
            if (this.getLigado() && 0 < (this.getVolume()))
            {
                this.setTocando(true);
            }
        }
        public void pause()
        {
            if (this.getLigado() && this.getTocando())
            {
                this.setTocando(false);
            }
        }



    }
}



