using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Bullet"))
			{
			Destroy (col.gameObject);
			Destroy (gameObject);
			}
}
}
