using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharp
{
    internal class Sesion4
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            //Ejercicio 1
            Console.WriteLine("Ejercicio #1:\nIngresa un numero para multiplicarlo del 1 al 10");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());
            EjercicioUno e1 = new EjercicioUno(numeroIngresado);
            e1.tablaMultiplicar();

            //Ejercicio2
            Console.WriteLine("Escribe un numero para saber si es POSITIVO o NEGATIVO");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());
            EjercicioDos e2 = new EjercicioDos(numeroIngresado);
            e2.obtenerSigno();
            
            //Ejercicio 3
            EjercicioTres e3 = new EjercicioTres(cantidadDibujos: 3, ancho: 5, alto: 4, relleno: true);
            e3.dibujarRectanguloCuadrado();
        }
        public struct EjercicioUno
        {
            private int numero { get; set; }

            public EjercicioUno(int numero) { 
                this.numero = numero;
            }   

            public void tablaMultiplicar()
            {
                int i = 1;
                int producto = 0;

                while (i<=10)
                {
                    producto = this.numero * i;
                    Console.WriteLine($"{i} x {this.numero} = {producto}");
                    i++;
                }
            }
        }
        public struct EjercicioDos
        {
            private int numero { get; set; }
            private int contadorPositivo { get; set; }  
            private int contadorNegativo { get; set; }

            public EjercicioDos(int numero)
            {
                this.numero = numero;
                this.contadorPositivo = 0;
                this.contadorNegativo = 0;
            }
            
            public void obtenerSigno()
            {
                if (this.numero > 0 ) {
                    Console.WriteLine($"El numero {this.numero} es POSITIVO");
                } else if (this.numero < 0) {
                    Console.WriteLine($"El numero {this.numero} es NEGATIVO");
                } 
            }
        }
        public struct EjercicioTres
        {
            private int ancho { get; set; }
            private int alto { get; set; }
            private int cantidadDibujos { get; set; }
            private Boolean relleno { get; set; }

            public EjercicioTres(int ancho, int alto, int cantidadDibujos, Boolean relleno)
            {
                this.ancho = ancho;
                this.alto = alto;
                this.cantidadDibujos = cantidadDibujos;
                this.relleno = relleno;
            }

            public void dibujarRectanguloCuadrado()
            {
                for (int k=0; k<this.cantidadDibujos; k++)
                {
                    if (this.relleno)
                    {
                        for (int i=0; i<this.alto; i++) //for que se encarga de pintar el ancho
                        {
                            for (int j = 0; j < this.ancho; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    } else
                    {
                        for (int i = 0; i < this.alto; i++) //for que se encarga de pintar el ancho
                        {
                            for (int j = 0; j < this.ancho; j++)
                            {
                                if (j != 0 && j != ancho-1 & i != 0 && i != this.alto-1)
                                {
                                    Console.Write(" ");
                                } else
                                {
                                    Console.Write("*");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("\n");
                }
            }

        }
    }
}
