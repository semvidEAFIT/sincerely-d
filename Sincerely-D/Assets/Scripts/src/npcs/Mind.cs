using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Character))]
public class Mind : Node {
	
	private State state;
	private Character character;
	
	public override void Start(){
		base.Start();
		character = GetComponent<Character>();	
		state = character.GetDefaultState();
	}
	
	public override void Refresh (Node node)
	{
		state.Refresh(character, node);
	}
}
