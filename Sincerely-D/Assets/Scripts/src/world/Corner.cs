using UnityEngine;
using System.Collections.Generic;

[RequireComponent (typeof(BoxCollider))]
public class Corner : MonoBehaviour {

	public List<Vector3> directions; //Vectores de direccion, no necesariamente unitarios
	
	public List<Transform> positions; //Puntos, cabezas de vectores de direccion
	
	public void Awake(){
		for(int i = 0; i < positions.Count; i++){
			directions.Add((positions[i].position - transform.position).normalized);
		}
	}
	
	public void Update(){
		foreach(Vector3 v in directions){
			Debug.DrawRay(transform.position, v, Color.green, (v - transform.position).sqrMagnitude);
		}
	}
}
