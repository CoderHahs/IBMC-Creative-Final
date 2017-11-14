using UnityEngine;
using System.Collections;

public class boxpickup : MonoBehaviour {

	private ProfilesFound boxes;



	// Use this for initialization
	void Start () {
		boxes = FindObjectOfType<ProfilesFound> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "Player") {
			boxes.boxfound();
		}
	}
}
