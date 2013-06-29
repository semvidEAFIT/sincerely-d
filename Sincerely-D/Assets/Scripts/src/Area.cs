using UnityEngine;
using System.Collections;

public class Area : Node {
	
	public override void Start(){
		base.Start();
		foreach(Node n in focus){
			AddObserver(n);
		}	
	}
	
	public override void Notify(Node target, Event e){
		foreach(Node n in Observers){
			if(!n.Equals(target)){
				n.Notify(target, e);	
			}
		}
	}
}
