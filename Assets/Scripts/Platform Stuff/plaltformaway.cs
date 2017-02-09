using UnityEngine;
using System.Collections;

public class plaltformaway : MonoBehaviour {

	public PlatformManager platformManager;

	private PlatformManager platformSystem; 

	// Use this for initialization
	void Start () {
	
		platformManager = FindObjectOfType<PlatformManager> ();

		platformSystem = FindObjectOfType<PlatformManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			platformSystem.TakePlat ();
		}
						
	}
}
