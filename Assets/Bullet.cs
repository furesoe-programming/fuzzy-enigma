using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

		Rigidbody m_rigid;
		public float power = 50f;

	// Use this for initialization
	 void Start () {
		 m_rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += transform.forward * 1.0f;

		m_rigid.AddForce(transform.forward * power);
	

	}
}
