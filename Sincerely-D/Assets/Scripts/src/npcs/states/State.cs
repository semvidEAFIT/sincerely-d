using UnityEngine;
using System.Collections;

public abstract class State{
	
	protected Character body;
	protected Mind mind;
	
	public State(Character body, Mind mind){
		this.body = body;
		this.mind = mind;
	}
	
	public abstract void Notify(Node target, Event e);
	public abstract void Update();
	public abstract void Leave();
	public abstract void Start();
}
