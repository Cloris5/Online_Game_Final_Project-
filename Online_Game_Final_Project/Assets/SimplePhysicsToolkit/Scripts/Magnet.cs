﻿using UnityEngine;
using System.Collections;

/* Simple Physics Toolkit - Magnet
 * Description: Magnet applies force to any rigidbody within range,
 * 				this force is not applied differently based on distance (Future Feature).
 * Required Components: None
 * Author: Dylan Anthony Auty
 * Version: 1.0
 * Last Change: 2016-01-16
*/
public class Magnet : MonoBehaviour {
	public float magnetForce = 15.0f;
	public bool attract = true;
	public float innerRadius = 2.0f;
	public float outerRadius = 5.0f; 
	
	// Update is called once per frame
	void Update () {
		if (attract) {
			Collider[] objects = Physics.OverlapSphere (transform.position, outerRadius);
			foreach (Collider col in objects) {
				if (col.GetComponent<Rigidbody> ()) { //Must be rigidbody
					if (Vector3.Distance (transform.position, col.transform.position) > innerRadius) {
						//Apply force in direction of magnet center
						col.GetComponent<Rigidbody> ().AddForce (magnetForce * (transform.position - col.transform.position).normalized, ForceMode.Force);
					} else {
						//Inner Radius float gentle - Future additional handling here
					}
				}
			}
		}	
	}
	
	void OnDrawGizmos(){
		if (attract) {
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(transform.position, outerRadius);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(transform.position, innerRadius);
		}
	}
}
