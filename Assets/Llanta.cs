using UnityEngine;
using System.Collections;

public class Llanta : MonoBehaviour {

	// Use this for initialization
	public void  Crearllanta (Vector3 posicion, Vector3 rotacion, Vector3 escala) {

		GameObject cylinder; 
		cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder); 
		cylinder.name="llanta";
		cylinder.transform.localScale = escala;
		cylinder.transform.position = posicion;
		cylinder.transform.eulerAngles = rotacion;


	}
	

}
