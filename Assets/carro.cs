using UnityEngine;
using System.Collections;

public class Carro : MonoBehaviour {


	public void crearCarro(){
		Capa crr = new Capa ();
		Llanta rue = new Llanta ();
		Puerta spo = new Puerta ();

		crr.crearcapa (new Vector3 (0f,0.5360004f , 0.2141948f),new Vector3 (0f, 0f, 0f),new Vector3 (2.46025f, 0.5311695f, 1.147772f));
		crr.crearcapa (new Vector3 (-0.7122843f,	0.7607864f,	0.2174655f),new Vector3 (0f,0f,19.20206f),new Vector3 (1f,0.3750001f,1.075f));
		crr.crearcapa (new Vector3 (0.4580485f,1.097695f,0.2062523f),new Vector3 (0f, 0f, 0f),new Vector3 (1.551363f,0.6625f,1.103316f));
		rue.Crearllanta (new Vector3 (-0.8121944f,0.5081124f,0.8335477f),new Vector3 (4.645006f,270.5062f,88.75655f),new Vector3 (0.8480469f,0.07593405f,1f));
		rue.Crearllanta (new Vector3 (-0.8252527f,0.5347831f,-0.3991807f),new Vector3 (4.645006f,270.5062f,88.75655f),new Vector3 (0.8480469f,0.07593405f,1f));
		rue.Crearllanta (new Vector3 (0.7393813f,0.5858006f,-0.3812524f),new Vector3 (4.645006f,270.5062f,88.75655f),new Vector3 (0.8480469f,0.07593405f,1f));
		rue.Crearllanta (new Vector3 (0.764918f,00.4997466f,0.8026705f),new Vector3 (4.645006f,270.5062f,88.75655f),new Vector3 (0.8480469f,0.07593405f,1f));
		spo.crearpuerta (new Vector3 (-0.04161697f,0.908314f,-0.330678f),new Vector3 (0f,90f,0f),new Vector3 (0.0001f,1f,0.5088474f));
		spo.crearpuerta (new Vector3 (-0.04161699f,0.9200523f,0.7020085f),new Vector3 (0f,90f,0f),new Vector3 (0.0001f,1f,0.5088474f));
		
	}
	
}
