using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CampaignSelectControl : MonoBehaviour {
    
    public TapGesture TheatertapGesture;
    public TapGesture WarfaretapGesture;
    public TapGesture SceneLoadtapGesture;
    public TapGesture CanceltapGesture;
    public Transform TheaterDiscribePanel;
    //public TapGesture backScenetapGesture;
    public string nextSceneName;
    public string previosSceneName;

    private int val = 0;
	// Use this for initialization

    private void OnEnable()
    {
        TheatertapGesture.Tapped += TheaterOnTapped;
        WarfaretapGesture.Tapped += WarfareOnTapped;
        SceneLoadtapGesture.Tapped += SceneLoadOnTapped;
        CanceltapGesture.Tapped += CancelLoadOnTapped;
        //backScenetapGesture.Tapped += backOnTapped;
    }

    private void OnDisable()
    {
        TheatertapGesture.Tapped -= TheaterOnTapped;
        WarfaretapGesture.Tapped -= WarfareOnTapped;
        SceneLoadtapGesture.Tapped -= SceneLoadOnTapped;
        CanceltapGesture.Tapped -= CancelLoadOnTapped;
        //backScenetapGesture.Tapped -= backOnTapped;
    }

    private void TheaterOnTapped(object sender, EventArgs e)
    {
        //TheaterDiscribePanel.transform.position = new Vector3((Screen.width) / 2, (Screen.height) / 2, 0);
        TheaterDiscribePanel.gameObject.SetActive(true);
        val = 1;
    }
    private void WarfareOnTapped(object sender, EventArgs e)
    {
        //TheaterDiscribePanel.transform.position = new Vector3((Screen.width) / 2, (Screen.height) / 2, 0);
        TheaterDiscribePanel.gameObject.SetActive(true);
        val = 2;
    }
    private void SceneLoadOnTapped(object sender, EventArgs e)
    {
        if (val == 1) SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
    private void CancelLoadOnTapped(object sender, EventArgs e)
    {
        TheaterDiscribePanel.gameObject.SetActive(false);
    }
    /*private void backOnTapped(object sender, EventArgs e)
    {
        SceneManager.LoadScene(previosSceneName, LoadSceneMode.Single);
    }*/
}
