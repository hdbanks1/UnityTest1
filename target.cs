using UnityEngine;


public class target : MonoBehaviour {	
	public float health= 50;
	public Animator myAnim;
	public void Start(){
		myAnim = GetComponent<Animator> ();
	}

	public void TakeDamage(float amount){
		health -= amount;
		myAnim.SetTrigger("hurt");
		if(health <=0f)
		{
			Die();
		}
	}

	void Die()
	{
		myAnim.SetTrigger("Die");
		Destroy(gameObject,10);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
