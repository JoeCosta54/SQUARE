using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct DialogueDatabase
{
	public DialogueFile[] en;
	public DialogueFile[] es;
	public DialogueFile[] jp;
}

[System.Serializable]
public struct DialogueFile 
{
	public int dialogueID; //The ID of the dialogue
	public string dialogueFileLocation; //The location of the Dialogue struct.
}

[System.Serializable]
public struct Dialogue 
{
	public Line[] dialogueLines; //Read these until the line sauys startChoice == true or until end.
	public Choice dialogueChoice; //If not null. Display the choices and on selection start that dialogueID
	//If not null, and Upon a choice, clear the lineQueue and fill the next lineQueue with the next Dialogue
}

[System.Serializable]
public struct Line 
{
	public string lineText; //Show this until the end of the audioClip.
	public string audioClip; //Audio clip to play, when finished play the next in the list if there is one.
	public bool startChoice; //if this is true, the dialogueChoice gets shown while people are talking. Allowing for inturuptions
}

[System.Serializable]
public struct Choice
{
	public int[] choiceDialogueIDs; //Dialogue to go to on each choice, must match the number of choice text
	public string[] choiceText; //Labels for the choices.
}