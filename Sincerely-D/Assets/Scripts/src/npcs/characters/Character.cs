using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (CharacterController))]
[RequireComponent (typeof (Mind))]
public abstract class Character : MonoBehaviour {
	
	public Corner startingDirection;
	protected CharacterController characterController;
	protected Mind mind;
	
	void Awake(){
		if(startingDirection == null){
			throw new Exception("No starting direction");
		}
		characterController = GetComponent<CharacterController>();	
		mind = GetComponent<Mind>();
	}
	
	public void Move(Vector3 position){
				
	}
	
	public abstract State GetDefaultState();
}
