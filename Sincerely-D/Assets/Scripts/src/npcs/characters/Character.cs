using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (CharacterController))]
public abstract class Character : MonoBehaviour {
	
	public Corner startingDirection;
	private CharacterController characterController;
	
	void Awake(){
		if(startingDirection == null){
			throw new Exception("No starting direction");
		}
	}
	
	void Start(){
		characterController = GetComponent<CharacterController>();	
	}
	
	public void Move(Vector3 position){
				
	}
	
	public abstract State GetDefaultState();
}
