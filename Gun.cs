using UnityEngine;
using System.Collections;

public class Gun: MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public Light fpsLight;
    public Camera fpsCam;
	public ParticleSystem muzzleflash;
	public float fireRate = .15f;
	oi line;
	public Animator myAnim;

	public void Start()

	{
		line = GetComponent<LineRenderer> ();
		myAnim = GetComponent<Animator> ();
	}
    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
		myAnim.SetTrigger ("recoil");
		muzzleflash.Play ();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range));
        {
            Debug.Log(hit.transform.name);
			target target = hit.transform.GetComponent<target>();
		if(target != null)
			{
				target.TakeDamage(damage); 
			}
			Ray ray = new Ray(transform.position, transform.forward);
			line.SetPosition(0, ray.origin);
			line.SetPosition(1, ray.GetPoint(100));
		}
	}
}
