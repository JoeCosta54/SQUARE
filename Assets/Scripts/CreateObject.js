var particle : GameObject;
	function Update () 
		
				
		{

		if (Input.GetButtonDown ("Fire1")) 
		{
			// Construct a ray from the current mouse coordinates
			var hit : RaycastHit;
				var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, hit)) {
				if(hit.collider.gameObject.tag != "Soul") {
				    Instantiate (particle, transform.position, transform.rotation);
				}
		//if (hit.colider.gameObject.tag=="soul")
				// Create a particle if hit

			}
		}
	
	}