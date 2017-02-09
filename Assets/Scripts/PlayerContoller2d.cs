using UnityEngine;
using System.Collections;

public class PlayerContoller2d : MonoBehaviour 
{

	public float moveSpeed;
	public float jumpHeight;
	public float currentHealth;
	public float maxHealth;

	public Transform groundPoint;
	public float radius;
	public LayerMask groundMask;

	
	bool isGrounded;
	Rigidbody2D rb2d;
	
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
		currentHealth = maxHealth;
	}

	void Update () 
	{
		Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb2d.velocity.y);
		rb2d.velocity = moveDir;

		isGrounded = Physics2D.OverlapCircle (groundPoint.position, radius, groundMask);
	
		if (Input.GetAxisRaw ("Horizontal") == 1) 
			{
				transform.localScale = new Vector3 (1, 1, 1);
			} 
		else if (Input.GetAxisRaw ("Horizontal") == -1) 
			{
				transform.localScale = new Vector3 (-1, 1, 1);
			}
	if (Input.GetKeyDown (KeyCode.Space)&& isGrounded) 
		{
			rb2d.AddForce(new Vector2(0, jumpHeight));
		}

		if (currentHealth <= 0) 
		{
			Die();
		}
	}


	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere (groundPoint.position, radius);
	}

	public void TakeDamage(int dmg)
	{
		currentHealth -= dmg;
	}


	void Die()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

}
