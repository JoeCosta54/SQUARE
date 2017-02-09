using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlatformManager : MonoBehaviour {

	public int startingplatforms;
	private int plaltformCounter;

	private Text theText;

	public GameObject CreateObject;

	// Use this for initialization
	void Start () {
		theText = GetComponent<Text>();

		plaltformCounter = startingplatforms;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (plaltformCounter < 0)
		{
			CreateObject.SetActive(false);
		}
		theText.text = "x " + plaltformCounter;
	}

	public void GivePlat()
	{
		plaltformCounter++;
	}

	public void TakePlat()
	{
		plaltformCounter--;
	}

}
