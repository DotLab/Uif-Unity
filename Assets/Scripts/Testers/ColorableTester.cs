using UnityEngine;

public class ColorableTester : Tester {
	public Colorable Colorable;

	void OnValidate () {
		if (Colorable == null) Colorable = GetComponent<Colorable>();
	}

	public override void Test () {
		Colorable.SetColor(new Color(Random.value, Random.value, Random.value));
	}
}
