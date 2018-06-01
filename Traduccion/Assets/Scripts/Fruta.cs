using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;



class Fruta : ScriptableObject
    {
     
        
            public Fruta()
            {
                nombre1 = "Manzana";
                nombre2 = "Platano";
                nombre3 = "Naranja";
            }

            public string nombre1 { get; }
            public string nombre2 { get; }
            public string nombre3 { get; }
        
    }

