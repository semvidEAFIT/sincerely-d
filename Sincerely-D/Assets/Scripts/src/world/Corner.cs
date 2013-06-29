using UnityEngine;
using System.Collections.Generic;

[ExecuteInEditMode]
[RequireComponent (typeof(BoxCollider))]
public class Corner : MonoBehaviour {

	public List<Vector3> directions; //Vectores de direccion, no necesariamente unitarios
	
	public List<Transform> transforms; //Puntos, cabezas de vectores de direccion
	
	public void Awake(){
		for(int i = 0; i < transforms.Count; i++){
			directions.Add(transforms[i].position - transform.position);
		}
	}
	
	public void Update(){
		foreach(Vector3 v in directions){
			Debug.DrawRay(transform.position, v, Color.cyan, (v - transform.position).sqrMagnitude);
		}
	}
}
