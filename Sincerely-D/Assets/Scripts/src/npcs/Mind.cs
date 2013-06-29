using UnityEngine;
using System.Collections;

public class Mind : Node {
	
	private State state;

	public State State {
		get {
			return this.state;
		}
		set {
			state.Leave();
			state = value;
			state.Start();
		}
	}

	private Character character;
	
	public override void Awake(){
		base.Start();
		character = GetComponent<Character>();	
	}
	
	public override void Start(){
		base.Start();
		state = character.GetDefaultState();
	}
	
	void Update(){
		state.Update();
	}
	
	public override void Notify (Node node, Event e)
	{
		state.Notify(node, e);
	}
}
