using UnityEngine;

public abstract class Swapable <T> : MonoBehaviour, ISwapable<T> {
	public EasingType TransitionEasingType = EasingType.Cubic;
	public float TransitionDuration = 0.5f;

	public abstract void Swap (T newItem);

	public abstract void SilentSwap (T newItem);
}
