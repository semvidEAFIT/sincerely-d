using UnityEngine;
using System.Collections;

public abstract class Event {
	private Node origin;

	public Node Origin {
		get {
			return this.origin;
		}
	}	
	
	public Event(Node origin){
		this.origin = origin;
	}
}
