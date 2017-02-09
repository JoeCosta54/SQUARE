using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour 
{
	public int damage;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			other.GetComponent<PlayerContoller2d>().TakeDamage(damage);		
		}
	}




}
