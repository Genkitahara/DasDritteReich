using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartControl : MonoBehaviour {

    // Use this for initialization
    public string nextSceneName;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > 5.0f)
        {
            SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
        }
    }
}
