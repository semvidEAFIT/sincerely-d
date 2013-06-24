using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			this.transform.position += Left();
		}else if(Input.GetKey(KeyCode.D)){
			this.transform.position += Right();
		}
		if(Input.GetKey(KeyCode.W)){
			this.transform.position += Forward();
		}else if(Input.GetKey(KeyCode.S)){
			this.transform.position += Back();
		}
		
	}
	
	public Vector3 Left(){
		return new Vector3(-speed*Time.deltaTime,0,0);
	}
	public Vector3 Right(){
		return new Vector3(speed*Time.deltaTime,0,0);
	}
	
	
	public Vector3 Back(){
		return new Vector3(0,0,-speed*Time.deltaTime);
	}
	public Vector3 Forward(){
		return new Vector3(0,0,speed*Time.deltaTime);
	}
}
