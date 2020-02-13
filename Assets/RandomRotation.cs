using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {

	public float tumble;
	public Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.angularVelocity = new Vector3(1,1,1)*tumble;

		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
