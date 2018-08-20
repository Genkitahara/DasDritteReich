using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeaterSelcectControl : MonoBehaviour {

    public TapGesture PolishtapGesture;
    public TapGesture WestenFlonttapGesture;
    public TapGesture EastentapGesture;
    public TapGesture SceneLoadtapGesture;
    public TapGesture CancelLoadtapGesture;
    public TapGesture backScenetapGesture;
    public Transform DiscribePanel;
    public Text CampaignSampleText;
    public string nextSceneName;
    public string previosSceneName;
    public string SelectedTheaterName;

    private void OnEnable()
    {
        PolishtapGesture.Tapped += PolishOnTapped;
        WestenFlonttapGesture.Tapped += WestenFlontOnTapped;
        EastentapGesture.Tapped += EastenOnTapped;
        SceneLoadtapGesture.Tapped += SceneLoadOnTapped;
        CancelLoadtapGesture.Tapped += CancelLoadOnTapped;
        backScenetapGesture.Tapped += backOnTapped;
    }

    private void OnDisable()
    {
        PolishtapGesture.Tapped -= PolishOnTapped;
        WestenFlonttapGesture.Tapped -= WestenFlontOnTapped;
        EastentapGesture.Tapped -= EastenOnTapped;
        SceneLoadtapGesture.Tapped += SceneLoadOnTapped;
        CancelLoadtapGesture.Tapped += CancelLoadOnTapped;
        backScenetapGesture.Tapped += backOnTapped;
    }

    private void PolishOnTapped(object sender, EventArgs e)
    {
        DiscribePanel.gameObject.SetActive(true);
        CampaignSampleText.text = "Polish Campaign";
        SelectedTheaterName = "PolishCampaign";
    }
    private void WestenFlontOnTapped(object sender, EventArgs e)
    {
        DiscribePanel.gameObject.SetActive(true);
        CampaignSampleText.text = "Weasten Flont 1940";
        SelectedTheaterName = "WeastenFlont1940";
    }
    private void EastenOnTapped(object sender, EventArgs e)
    {
        DiscribePanel.gameObject.SetActive(true);
        CampaignSampleText.text = "Easten Front";
        SelectedTheaterName = "EastenFlont";
    }
    private void SceneLoadOnTapped(object sender, EventArgs e)
    {
        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }
    private void CancelLoadOnTapped(object sender, EventArgs e)
    {
        DiscribePanel.gameObject.SetActive(false);
    }
    private void backOnTapped(object sender, EventArgs e)
    {
        SceneManager.LoadScene(previosSceneName, LoadSceneMode.Single);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
