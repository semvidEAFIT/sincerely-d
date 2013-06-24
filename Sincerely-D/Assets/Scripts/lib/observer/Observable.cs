using UnityEngine;
using System.Collections.Generic;

public class Observable: MonoBehaviour {
    private List<IObserver> observers;
	
	public IObserver[] Observers {
		get {
			IObserver[] observers = new IObserver[this.observers.Count];
			this.observers.CopyTo(observers);
			return observers;
		}
	}
	
    private bool changed = false;

    void Awake() {
        observers = new List<IObserver>();
    }

    public void addObserver(IObserver observer) {
        observers.Add(observer);
    }

    protected void setChanges(){
        changed = true;
    }

    protected bool isChanged() {
        return changed;
    }

    protected void notifyAllObservers() {
        if(isChanged()){
            changed = false;
            foreach (IObserver observer in observers) {
                observer.Update(this);
            }
        }
    }

    public void removeObserver(IObserver observer) {
        observers.Remove(observer);
	}
	
	public void notifyObserver(IObserver observer){
		observer.Update(this);
	}
}