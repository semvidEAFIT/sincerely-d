using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
[RequireComponent (typeof (Mind))]
public abstract class Character : MonoBehaviour {
	
	protected CharacterController characterController;
	protected Mind mind;
	
	void Awake(){
		characterController = GetComponent<CharacterController>();
		mind = GetComponent<Mind>();
	}
	
	#region Movement
	private Vector3 finalPos, movement;
	public float speed;
	private bool moving;
	
	public void Move(Vector3 position){
		finalPos = position;
		moving = true;
	}
	
	public virtual void Update(){
		if(moving){
			if(transform.position != finalPos){
				movement = (finalPos - transform.position).normalized * speed;
				characterController.Move(movement * Time.deltaTime);
			}else{
				finalPos = Vector3.zero;
				movement = Vector3.zero;
				moving = false;
			}
		}
	}
	#endregion
	
	public abstract State GetDefaultState();
}
