 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

public class Shooter : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	int highscore = 10;
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetMouseButtonDown(0))
		{
			//var bullet = Resources.Load("Bullet");
			//Instantiate(bullet, this.transform.position, this.transform.rotation);

			RaycastHit hit;
			Ray ray = new Ray(transform.position, transform.forward);
			Debug.DrawRay(ray.origin, ray.direction, Color.magenta, 60);

			if (Physics.Raycast(ray, out hit, 1000) == true){

				if (hit.transform.gameObject.tag == "Cube"){
					Debug.DrawLine(ray.origin, hit.point, Color.cyan, 60);
					Rigidbody hitRigidbody = hit.transform.gameObject.GetComponent<Rigidbody>();

					if (hitRigidbody != null){
						GameObject explosion = GameObject.FindGameObjectWithTag("Explosion");

						if (explosion != null){
							ParticleSystemMultiplier psm = explosion.GetComponent<ParticleSystemMultiplier>();
							if (psm != null){
								psm.activate();
							}
						}
						hitRigidbody.AddExplosionForce(10f, hit.point, 2f,5f, ForceMode.Impulse);
						Debug.Log("Should explode");
					}
				}
				Debug.Log(hit.transform.gameObject.tag);


			}
		}
		

	}
}
