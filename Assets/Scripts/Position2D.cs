using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {
	public float axisOffset = 0;
	private Transform _transform;
	void Awake() {
		_transform = transform;
	}

	void Update () {
		Vector3 position = _transform.position;
	}
}
