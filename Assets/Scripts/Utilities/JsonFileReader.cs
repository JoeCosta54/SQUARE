using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonFileReader : MonoBehaviour {

	public static string ReadJsonFromResource(string path){
		string filePath = path.Replace(".json", "");
		TextAsset targetFile = Resources.Load<TextAsset>(filePath); 
		return targetFile.text;
	}

}
