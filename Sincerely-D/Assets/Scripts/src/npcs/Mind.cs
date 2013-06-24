using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Body))]
public abstract class Mind : Node {
	
	private State state;
	private Body body;
	
	void Start(){
		body = GetComponent<Body>();	
		state = GetDefaultState();
	}
	
	public override void Refresh (Node node)
	{
		state.Refresh(body, node);
	}
	
	public abstract State GetDefaultState();
}
