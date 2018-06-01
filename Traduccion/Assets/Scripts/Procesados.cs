using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;



class Procesados : ScriptableObject
    {
      
            public Procesados()
            {
                nombre1 = "Aceite";
                nombre2 = "Harina";
                nombre3 = "Pasta";
            }

            public string nombre1 { get; }
            public string nombre2 { get; }
            public string nombre3 { get; }
        
    }

