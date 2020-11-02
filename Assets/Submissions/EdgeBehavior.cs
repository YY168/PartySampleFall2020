using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeBehavior : MonoBehaviour
{
	public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
		// the bullet disappears if it hits walls/obstacles or damages the object if it fits the damageTag
		other.gameObject.GetComponents<PlayerController>()[0].edge += 1;
		Debug.Log(other.gameObject.GetComponents<PlayerController>()[0].edge);
		Destroy(gameObject);
	}
}
