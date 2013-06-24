using UnityEngine;
using System.Collections;

public class Area : Node {
	
	public Node[] nodes; 
	// Use this for initialization
	void Start () {
		foreach(Node n in nodes){
			n.AddObserver(this);
			AddObserver(n);
		}
	}
	
	public override void Refresh(Node target){
		foreach(Node n in Observers){
			if(!n.Equals(target)){
				n.Refresh(target);	
			}
		}
	}
}
