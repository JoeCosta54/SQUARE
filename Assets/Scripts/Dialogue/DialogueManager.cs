using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum Language{
	EN, ES, JP
}

public class DialogueManager : MonoBehaviour 
{
	[Header ("Dialogue Database")]
	public string dialogueDatabaseLocation = "Dialogue/database.json";
	public DialogueDatabase database;
	public Dictionary<int, string> dialogueDatabase;

	[Header ("Language")]
	public Language chosenLanguage;

	[Header ("Current Dialogue Info")]
	public List<Line> dialogueQueue;
	public Choice currentChoice;

	public static string currentLineDialogue;

	public void Awake(){
		dialogueDatabase = new Dictionary<int, string>();
		//Load the dialogueDatabase into the Dictionary
		database = JsonUtility.FromJson<DialogueDatabase>(JsonFileReader.ReadJsonFromResource(dialogueDatabaseLocation));
		switch (chosenLanguage) 
		{
			case Language.EN:
			  loadDialogueFromDB(database.en);
			  break;
			case Language.ES:
			  loadDialogueFromDB(database.es);
			  break;
			case Language.JP:
			  loadDialogueFromDB(database.jp);
			  break;
		}
	}

	public void Update(){
		//Check to see if the dialogueQueue has any lines to say. 
		if(dialogueQueue.Count >= 1){
			//Take the dialogue clip and go get it. 
			//dialogueQueue[0].audioClip;
			//Load the clip and set a reference.
			
			//Play the clip and add the text to the onscreen subtitle string.
			currentLineDialogue = dialogueQueue[0].lineText;
		}
	}

	public static void startDialogue(int id){
		//get the dialogue file from the database
		//Load the file into a Dialogue
		//Load the Lines into the dialogue Queue
		//Let the manager hit the update thread.
	}

	public void loadDialogueFromDB(DialogueFile[] langFiles){
		foreach (DialogueFile file in langFiles){
			Debug.Log(file.dialogueFileLocation);
			dialogueDatabase.Add(file.dialogueID, file.dialogueFileLocation);
		}
	}
}