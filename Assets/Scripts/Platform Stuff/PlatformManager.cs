using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlatformManager : MonoBehaviour {

	public int startingplatforms;
	public int plaltformCounter;
	public GameObject theText;
	public GameObject cursor;

	public GameObject[] platforms;
	public int currentPlatformID = 0;

	// Use this for initialization
	void Start () {
		plaltformCounter = startingplatforms;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
		if(Input.GetAxis("Mouse ScrollWheel") * 10 != 0){
			if(Input.GetAxis("Mouse ScrollWheel") * 10 > 0){
				currentPlatformID += 1;
			} else {
				currentPlatformID -= 1;
			}
		} else if(Input.GetKeyDown(KeyCode.Q)){

		}

		if(currentPlatformID < 0){
			currentPlatformID = platforms.Length - 1;
		} else if(currentPlatformID > platforms.Length - 1){
			currentPlatformID = 0;
		}

		if(plaltformCounter > 0 && Input.GetMouseButtonDown(0)){
			Debug.Log("Click");
			RaycastHit hitInfo;
			Physics.Raycast(cursor.transform.position, Vector3.forward, out hitInfo, 100.0f);
			if(hitInfo.collider != null && hitInfo.collider.gameObject.tag == "Soul") {

			} else {
				if(currentPlatformID >= 0 && currentPlatformID <= platforms.Length-1){
					GameObject go = (GameObject) Instantiate(platforms[currentPlatformID], cursor.transform.position, Quaternion.identity);
					go.transform.SetParent(this.transform);
					plaltformCounter--;
				}
			}
		}



		theText.GetComponent<Text>().text = "x " + plaltformCounter;
	}

	public void GivePlat()
	{
		plaltformCounter++;
	}

	public void TakePlat()
	{
		plaltformCounter--;
	}

	public int GetPlatCount()
	{
		return plaltformCounter;
	}

}
