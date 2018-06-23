using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

	private float _totalTime = 60;
	private Text _timerText;
	private bool _ready = false;

	void OnEnable()
	{
		SceneManager.sceneLoaded += SceneDidLoad;
		_timerText = gameObject.GetComponent<Text>();
		_timerText.text = "Loading...";
	}

	void SceneDidLoad(Scene scene, LoadSceneMode mode)
	{
		_ready = true;
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (_ready && Time.timeSinceLevelLoad < _totalTime)
		{
			_timerText.text = "" + (int) (_totalTime - Time.timeSinceLevelLoad);
		}
	}
}
