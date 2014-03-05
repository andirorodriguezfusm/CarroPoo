using UnityEngine;
using System.Collections;

public class Capa : MonoBehaviour {

	// Use this for initialization
	public void crearcapa (Vector3 posicion, Vector3 rotacion, Vector3 escala) {
		GameObject cube; 
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.name="capa";
		cube.transform.localScale = escala;
		cube.transform.position = posicion;
		cube.transform.eulerAngles = rotacion;

	}
	
	
}
