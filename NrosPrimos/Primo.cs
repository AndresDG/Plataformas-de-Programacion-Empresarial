using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NrosPrimos
{
    class Primo
    {

        private int primo;

        public Primo() {
            primo = 1;
        }

        public Primo(int Primo)
        {
            this.primo = Primo;
        }

        public int GPrimo { get => primo; set => primo = value; }

        /*private bool EsPrimo(int num) {
            num = num + 1;
            int cont = num - 1;
            bool verdad = false;

            while (cont >= 1)
            {
                if (num % cont == 0) {

                    break;

                }

                cont = cont - 1;

                
                
            }
            if (verdad) return true;

            return false;
        }*/
        public int NroPrimo(int pos){

            //int cont = 1;
            int contador = 0;

            while (contador < pos) {
                primo = this.primo + 1;
                int cont = this.primo - 1;
                //EsPrimo(this.primo);
                while (cont >= 1)
                {
                    if (this.primo % cont == 0)
                    {

                        break;

                    }

                    cont = cont - 1;
                }

                if (cont <= 1)
                {
                    contador = contador + 1;

                }
            }


            return this.primo;
        }



    }


   
}
