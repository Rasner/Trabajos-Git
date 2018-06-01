using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Program : MonoBehaviour
    {
	
	void Awake ()
	{
		
	}
	void FixedUpdate ()
	{
		cocina ();
		if (Input.GetKey(KeyCode.I)) 
		{
			procesados ();
		}
		if (Input.GetKey (KeyCode.F)) 
		{
			fruta ();
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			cocinando ();

		}
		if (Input.GetKey (KeyCode.N))
			cocinandoNF ();
		
	}
	 void cocina ()

	{
		Debug.Log ("Bienvenido a la cocina que desea cocinar");

		Debug.Log ("Presiona Enter para continua");
		if (Input.GetKeyUp (KeyCode.Return)) 
		{

			Debug.Log ("Que desea cocinar?");
			Debug.Log ("1)Locro");
			Debug.Log ("2)Pollo al sillao");
			Debug.Log ("3)Lomo Saltado");
			Debug.Log ("4)Carne Asada");
		}
			if (Input.GetKeyUp (KeyCode.Keypad1))	
				{
					ingredientes ();
				}
		if (Input.GetKeyUp (KeyCode.Keypad2))	
				{
					ingredientes ();
				}
		if (Input.GetKeyUp (KeyCode.Keypad3))	
				{
					ingredientes ();
				}
		if (Input.GetKeyUp (KeyCode.Keypad4))	
				{
					ingredientes ();
				}
			
			
		}



            
	     



		void ingredientes()
	{
		Debug.Log ("Estos son los ingredientes Naturales que se usaran");
		Naturales naturales = new Naturales ();
		Debug.Log (naturales.nombre1);
		Debug.Log (naturales.nombre2);
		Debug.Log (naturales.nombre3);
		Debug.Log ("Presiona I para continuar");

	}
		void procesados()
		{
		Debug.Log("Estos son los ingredientes Procesados que se usaran");
            Procesados procesados = new Procesados();
		Debug.Log(procesados.nombre1);
		Debug.Log(procesados.nombre2);
		Debug.Log(procesados.nombre3);
		Debug.Log("Presiona F para continuar");

		}
	void fruta()
	{
		Debug.Log ("Desea Agregar estas fruta?");
		Fruta frutas = new Fruta ();
		Debug.Log (frutas.nombre1);
		Debug.Log (frutas.nombre2);
		Debug.Log (frutas.nombre3);

		Debug.Log ("Presiona S para si o N para No");

	}   

		void cocinando()
		{
		

		Debug.Log ("Se Utilizaran las frutas");
		Debug.Log ("Cocinando...");
		Debug.Log ("Su Orcen esta lista");
		Debug.Log ("Gracias por usar el sistema");



		}
		void	cocinandoNF()
		{
			Debug.Log("No se utilizaran las frutas");
			Debug.Log("Cocinando...");
			Debug.Log("Su Orcen esta lista");
			Debug.Log("Gracias por usar el sistema");
			
		}
			

			
      }



