var particle : GameObject;
	function Update () {
		if (Input.GetButtonDown ("Fire1")) {
			// Construct a ray from the current mouse coordinates
		    var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray)) {
				// Create a particle if hit
				Instantiate (particle, transform.position, transform.rotation);
			}
		}
	}