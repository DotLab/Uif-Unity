using UnityEngine;

public class SpriteSwapableTester : Tester {
	public SpriteSwapable Swapable;

	public Sprite[] sprites;

	void OnValidate () {
		if (Swapable == null) Swapable = GetComponent<SpriteSwapable>();
	}

	public override void Test () {
		Swapable.Swap(sprites[Random.Range(0, sprites.Length - 1)]);
	}
}
