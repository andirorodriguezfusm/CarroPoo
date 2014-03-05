using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {

	// Use this for initialization
	public void crearpuerta (Vector3 posicion, Vector3 rotacion, Vector3 escala) {
		GameObject cube; 
		cube = GameObject.CreatePrimitive(PrimitiveType.Cube); 
		cube.name="puerta";
		cube.transform.localScale = escala;
		cube.transform.position = posicion;
		cube.transform.eulerAngles = rotacion;
	}
	

}
