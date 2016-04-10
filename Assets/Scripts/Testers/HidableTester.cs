using UnityEngine;
using Uif;

public class HidableTester : Tester {
	public Hidable Hidable;

	bool flag = true;

	void OnValidate () {
		if (Hidable == null) Hidable = GetComponent<Hidable>();
	}

	public override void Test () {
		if (flag) Hidable.Show();
		else Hidable.Hide();

		flag = !flag;
	}
}
