using UnityEngine;

public class ColorSwapableTester : Tester {
	public ColorSwapable Swapable;

	void OnValidate () {
		if (Swapable == null) Swapable = GetComponent<ColorSwapable>();
	}

	public override void Test () {
		Swapable.Swap(new Color(Random.value, Random.value, Random.value));
	}
}
