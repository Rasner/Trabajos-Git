using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;



class Naturales : ScriptableObject
        
    {
        public Naturales()
        {
           nombre1 = "Carne";
           nombre2 = "Sal";
           nombre3 = "Pimienta";
        }

        public string nombre1 { get; }
        public string nombre2 { get; }
        public string nombre3 { get; }
    }
