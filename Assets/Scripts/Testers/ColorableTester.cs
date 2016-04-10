using UnityEngine;
using Uif;

public class ColorableTester : Tester {
	public Colorable Hidable;

	void OnValidate () {
		if (Hidable == null) Hidable = GetComponent<Colorable>();
	}

	public override void Test () {
		Hidable.SetColor(new Color(Random.value, Random.value, Random.value));
	}
}
