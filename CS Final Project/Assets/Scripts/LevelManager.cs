using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

	public string NextScene = "";	// Set the scene as a string in the Inspector menu. Add the scene to Build Settings first!
	public string CurrentScene = "";
	private bool _moveOn = false;	// Sets a variable to either reset the scene or move on to the next scene (if true)
	private bool _isTriggerActivated = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (_isTriggerActivated)
		{
			if (_moveOn)
			{
				// Load the next scene asynchronously
                StartCoroutine(LoadAsyncScene(NextScene));
			}
			else
			{
				// Load the current scene, resetting it
				StartCoroutine(LoadAsyncScene(CurrentScene));
			}
			
		}

	}

	void DoActivateTrigger(GameObject source)
	{
		print("Endgame has been triggered - " + source.tag);	// Console debug message
		_isTriggerActivated = true;

		if (source.CompareTag("Finish"))	// Must tag the GameObject as "Finish"
		{
			_moveOn = true;
		}
		else 	// Must tag the GameObject as "Respawn"
		{
			_moveOn = false;
		}
	}

	public static IEnumerator LoadAsyncScene(string scene)
	{
		AsyncOperation asyncLoader = SceneManager.LoadSceneAsync(scene);

		while (!asyncLoader.isDone)
		{
			yield return null;
		}
	}
	
}
