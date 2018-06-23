using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;
using Button = UnityEngine.UI.Button;

public class MainSceneLogic : MonoBehaviour
{
	
	// Adds an Inspector field to add an in-game button
	public Button StartButton;
	
	// Use this for initialization
	void Start ()
	{
		StartButton = StartButton.GetComponent<Button>();
		StartButton.onClick.AddListener(OnClick);	// Attach a listener to the StartButton
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//
	void OnClick()
	{
		StartCoroutine(LevelManager.LoadAsyncScene("Level1Scene"));	// Loads the first scene (see LevelManager)
	}


}
