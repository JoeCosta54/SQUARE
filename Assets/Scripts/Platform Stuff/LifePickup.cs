using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {

	private PlatformManager platformsystem;

	// Use this for initialization
	void Start () 
	{
		platformsystem = FindObjectOfType<PlatformManager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
	
		if (other.name == "Player") 
		{
			platformsystem.GivePlat();
			Destroy(gameObject);
		}
	}


}
