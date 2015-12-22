using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	public float destroyTime = 7.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyTime);
	}

}
