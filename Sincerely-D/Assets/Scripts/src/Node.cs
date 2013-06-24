using UnityEngine;
using System.Collections.Generic;

public abstract class Node: MonoBehaviour {
	private List<Node> observers;
	
	public Node[] Observers {
		get {
			Node[] observers = new Node[this.observers.Count];
			this.observers.CopyTo(observers);
			return observers;
		}
	}
	
	public Node[] focus; 
	// Use this for initialization
	public virtual void Start () {
		foreach(Node n in focus){
			n.AddObserver(this);
		}
	}
	
    private bool changed = false;

    void Awake() {
        observers = new List<Node>();
    }
	
	//TODO mantener areas en lista diferente
    public void AddObserver(Node observer) {
        observers.Add(observer);
    }

    protected void SetChanges(){
        changed = true;
    }

    protected bool IsChanged() {
        return changed;
    }

    protected void RefreshAllObservers() {
        if(IsChanged()){
            changed = false;
            foreach (Node observer in observers) {
                observer.Refresh(this);
            }
        }
    }

    public void RemoveObserver(Node observer) {
        observers.Remove(observer);
	}
	
	public void RefreshObserver(Node observer){
		observer.Refresh(this);
	}
	
	public abstract void Refresh(Node node);
}
