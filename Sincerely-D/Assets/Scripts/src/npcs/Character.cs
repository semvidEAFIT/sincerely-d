using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public abstract class Character : MonoBehaviour {
	
	private CharacterController characterController;
	
	void Start(){
		characterController = GetComponent<CharacterController>();	
	}
	
	public void Move(Vector3 position){
				
	}
	
	public abstract State GetDefaultState();
}
