using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CampaignSelectControl : MonoBehaviour {
    
    public TapGesture TheatertapGesture;
    public TapGesture WarfaretapGesture;
    public Transform TheaterDiscribePanel;
    public string nextSceneName;

    private int val = 0;
	// Use this for ißnitialization

    private void OnEnable()
    {
        TheatertapGesture.Tapped += TheaterOnTapped;
        WarfaretapGesture.Tapped += WarfareOnTapped;
    }

    private void OnDisable()
    {
        TheatertapGesture.Tapped -= TheaterOnTapped;
        WarfaretapGesture.Tapped -= WarfareOnTapped;
    }

    private void TheaterOnTapped(object sender, EventArgs e)
    {
        TheaterDiscribePanel.transform.position = new Vector3((Screen.width) / 2, (Screen.height) / 2, 0);
        val = 1;
    }
    private void WarfareOnTapped(object sender, EventArgs e)
    {
        TheaterDiscribePanel.transform.position = new Vector3((Screen.width) / 2, (Screen.height) / 2, 0);
        val = 2;
    }
    public void SceneLoadStart()
    {
        if (val == 1) SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
}
