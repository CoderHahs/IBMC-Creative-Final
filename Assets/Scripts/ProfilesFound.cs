using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ProfilesFound : MonoBehaviour {

	private int profileCounter;
	
	private Text theText;



	// Use this for initialization
	void Start () {
		theText = GetComponent <Text> ();
		
		profileCounter = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		theText.text = " x " + profileCounter;
	}

	public void boxfound ()
	{
		profileCounter ++;
		
	}

	public bool box10 ()
	{
		if (profileCounter == 10)
			return true;
		else
			return false;
	}
	
}

