using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;

	public string levelToLoad;

	private ProfilesFound boxes;


	// Use this for initialization
	void Start () {
		playerInZone = false;

		boxes = FindObjectOfType<ProfilesFound> ();
	}
	
	// Update is called once per frame
	void Update () {

		bool numberofboxes = boxes.box10 ();

		if(Input.GetKeyDown(KeyCode.UpArrow) && playerInZone)
		{
			if (numberofboxes == true)
			Application.LoadLevel(levelToLoad);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			playerInZone = true;
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag== "Player") {
			playerInZone = false;
		}
	}


}
