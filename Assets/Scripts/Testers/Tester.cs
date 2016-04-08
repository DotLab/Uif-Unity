using UnityEngine;
using System.Collections;

public abstract class Tester : MonoBehaviour {
	public float ExecuteInterval = 1;

	void Start () {
		StartCoroutine(TestHandler());
	}

	IEnumerator TestHandler () {
		while (true) {
			Test();

			yield return new WaitForSeconds(ExecuteInterval);
		}
	}

	public abstract void Test ();
}
