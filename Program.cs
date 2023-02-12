using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace actividad_1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Este Programa fue creado para recopilar y mostrar datos de 7DS(Un videojuego)");
            Console.WriteLine("Favor de poner todos los datos para que no haya ninguna falla");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("¿Quiere ver los datos de un personaje o un equipo entero(el equipo se conforma de 4 personajes)?");
            Console.WriteLine("Favor de poner 1 o 4(NO ESCRIBA CUALQUIER OTRO DATO POR QUE NO FUNCIONARA)");
            int NumPers = int.Parse(Console.ReadLine());
            Console.Clear();
            while(NumPers > 0)
            {
                while (NumPers == 1)
                {
                    Personajes Personaje = new Personajes();
                    string Nom = NomDePers("");
                    int levl = Nivel(0);
                    int ps = PS(0);
                    int Ataq = Ataque(0);
                    int Def = Defensa(0);
                    int cc = CC(ps, Ataq, Def);


                    Personaje.Ataque = Ataq;
                    Personaje.PS = ps;
                    Personaje.Nivel = levl;
                    Personaje.Defensa = Def;
                    Personaje.CC = cc;
                    Personaje.NomdePersonaje = Nom;
                    Console.WriteLine(Personaje.NomdePersonaje);
                    Console.WriteLine("Nivel: " + Personaje.Nivel);
                    Console.WriteLine("CC: " + Personaje.CC);
                    Console.WriteLine("Ataque: " + Personaje.Ataque);
                    Console.WriteLine("Defensa:" + Personaje.Defensa);
                    Console.WriteLine("PS: " + Personaje.PS);
                    NumPers = 0;
                    break;
                }
                while (NumPers == 4)
                {
                    Personajes Personaje = new Personajes();
                    Equipos Equipo1 = new Equipos();
                    string Nom = NomDePers("");
                    int levl = Nivel(0);
                    int ps = PS(0);
                    int Ataq = Ataque(0);
                    int Def = Defensa(0);
                    int cc = CC(ps, Ataq, Def);
                    int cce;
                    Personaje.Ataque = Ataq;
                    Personaje.PS = ps;
                    Personaje.Nivel = levl;
                    Personaje.Defensa = Def;
                    Personaje.CC = cc;
                    Personaje.NomdePersonaje = Nom;
                    Console.WriteLine(Personaje.NomdePersonaje);
                    Console.WriteLine("Nivel: " + Personaje.Nivel);
                    Console.WriteLine("CC: " + Personaje.CC);
                    Console.WriteLine("Ataque: " + Personaje.Ataque);
                    Console.WriteLine("Defensa:" + Personaje.Defensa);
                    Console.WriteLine("PS: " + Personaje.PS);


                    Personajes Personaje2 = new Personajes();
                    Nom = NomDePers("");
                    levl = Nivel(0);
                    ps = PS(0);
                    Ataq = Ataque(0);
                    Def = Defensa(0);
                    cc = CC(ps, Ataq, Def);
                    Personaje2.Ataque = Ataq;
                    Personaje2.PS = ps;
                    Personaje2.Nivel = levl;
                    Personaje2.Defensa = Def;
                    Personaje2.CC = cc;
                    Personaje2.NomdePersonaje = Nom;
                    Console.WriteLine(Personaje2.NomdePersonaje);
                    Console.WriteLine("Nivel: " + Personaje2.Nivel);
                    Console.WriteLine("CC: " + Personaje2.CC);
                    Console.WriteLine("Ataque: " + Personaje2.Ataque);
                    Console.WriteLine("Defensa:" + Personaje2.Defensa);
                    Console.WriteLine("PS: " + Personaje2.PS);


                    Personajes Personaje3 = new Personajes();
                    Nom = NomDePers("");
                    levl = Nivel(0);
                    ps = PS(0);
                    Ataq = Ataque(0);
                    Def = Defensa(0);
                    cc = CC(ps, Ataq, Def);
                    Personaje3.Ataque = Ataq;
                    Personaje3.PS = ps;
                    Personaje3.Nivel = levl;
                    Personaje3.Defensa = Def;
                    Personaje3.CC = cc;
                    Personaje3.NomdePersonaje = Nom;
                    Console.WriteLine(Personaje3.NomdePersonaje);
                    Console.WriteLine("Nivel: " + Personaje3.Nivel);
                    Console.WriteLine("CC: " + Personaje3.CC);
                    Console.WriteLine("Ataque: " + Personaje3.Ataque);
                    Console.WriteLine("Defensa:" + Personaje3.Defensa);
                    Console.WriteLine("PS: " + Personaje3.PS);


                    Personajes Personaje4 = new Personajes();
                    Nom = NomDePers("");
                    levl = Nivel(0);
                    ps = PS(0);
                    Ataq = Ataque(0);
                    Def = Defensa(0);
                    cc = CC(ps, Ataq, Def);
                    cce = CCE(Personaje.CC, Personaje2.CC, Personaje3.CC, Personaje4.CC);
                    Personaje4.Ataque = Ataq;
                    Personaje4.PS = ps;
                    Personaje4.Nivel = levl;
                    Personaje4.Defensa = Def;
                    Personaje4.CC = cc;
                    Personaje4.NomdePersonaje = Nom;
                    Equipo1.CCE = cce;
                    Console.WriteLine(Personaje4.NomdePersonaje);
                    Console.WriteLine("Nivel: " + Personaje4.Nivel);
                    Console.WriteLine("CC: " + Personaje4.CC);
                    Console.WriteLine("Ataque: " + Personaje4.Ataque);
                    Console.WriteLine("Defensa:" + Personaje4.Defensa);
                    Console.WriteLine("PS: " + Personaje4.PS);
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("CC de tu Equipo: " + Equipo1.CCE);
                    NumPers = 0;

                }
                while (NumPers == 0)
                {
                    Console.WriteLine("¿Quiere revisar los datos de otro personaje o equipo?");
                    Console.WriteLine("1 = si    2 = no");
                    int siono = int.Parse(Console.ReadLine());
                    while (siono == 1)
                    {
                        Console.WriteLine("¿Un solo Personaje (1) o el Equipo(2)?");
                        int CantPer = int.Parse(Console.ReadLine());
                        Console.Clear();
                        while (CantPer == 1)
                        {
                            NumPers = 1;
                            break;
                        }
                        

                        while (CantPer == 2)
                        {
                            NumPers = 4;
                            break;
                        }
                        break;
                    }
                    while (siono == 2)
                    {
                        Console.WriteLine("Muchas gracias por usar este programa");
                        Console.ReadKey();
                        NumPers = -1;
                        break;
                    }

                }
            }

            
            
        }
        
        static string NomDePers(string Nomdeper)
        {

            Console.WriteLine("Cual es el Nombre de su personaje");
            string NomDePers = Console.ReadLine();
            NomDePers = "Nombre:" + NomDePers;
            Console.Clear();
            return NomDePers;

        }
        static int Nivel(int level)
        {

            Console.WriteLine("Cual es el nivel de su personaje");
            int Nivel = int.Parse(Console.ReadLine());
            Console.Clear();
            return Nivel;

        }
        static int PS(int ps)
        {
            
            Console.WriteLine("Cual es el PS de su personaje");
            int PS = int.Parse(Console.ReadLine());
            Console.Clear();
            return PS;

        }
        static int Ataque(int Ataq)
        {
           
            Console.WriteLine("Cual es el Ataque de su personaje");
            int Ataque = int.Parse(Console.ReadLine());
            Console.Clear();
            return Ataque;

        }
        static int Defensa (int Def)
        {

            Console.WriteLine("Cual es el Defensa de su personaje");
            int Defensa = int.Parse(Console.ReadLine());
            Console.Clear();
            return Defensa;

        }
        static int CC(int A ,int B, int C)
        {

            int CC = (A + B + C) / 3;
            return CC;

        }
        static int CCE (int A, int B, int C , int D)
        {

            int CCE = A + B + C + D;
            return CCE;

        }
    }

}
