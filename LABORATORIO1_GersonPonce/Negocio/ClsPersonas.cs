using LABORATORIO1_GersonPonce.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO1_GersonPonce.Negocio
{
    public class ClsPersonas

    {
        public String calcularIMC(Personas personas) {
            double pro = personas.Peso /
             Math.Pow(personas.Altura, 2);
                if (pro <= 24)
                
                {
                    return "Tu peso es ideal";
                } return " tu tienes Sobre peso";


            }
        public string EsMayorDeEdad(Personas edad)

        {
            if (edad.Edad < 18) {
                return "Tu eres menor  de edad";

            }return "Tu eres mayor de edad";
        }
        }
        
         
        
    }
