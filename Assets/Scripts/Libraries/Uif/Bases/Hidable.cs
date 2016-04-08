using UnityEngine;

public abstract class Hidable : MonoBehaviour, IHidable {
	public abstract void Hide ();

	public abstract void Show ();

	public abstract bool Hided ();

	public abstract bool Shown ();
}
