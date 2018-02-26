using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	public int health = 50;
	Animator anim;
	// Use this for initialization
	public void TakeDamage (int amount)
	{
		health -= amount;
		if (health <= 0) {
			Die ();	
		}
	}
	void Die(){
		anim = GetComponent<Animator> ();
		anim.SetTrigger ("Dead");
		Destroy (gameObject, 3f);

	}
}
