using System;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TheaterMainSceneControl : MonoBehaviour
{

    public TapGesture backScenetapGesture;
    public TapGesture WeaponProductiontap;
    public TapGesture StrategyMissiontap;
    public TapGesture TechnologyReserchtap;

    public string previosSceneName;

    private void OnEnable()
    {
        backScenetapGesture.Tapped += backOnTapped;
        WeaponProductiontap.Tapped += WeaponProductionOnTapped;
        StrategyMissiontap.Tapped += StrategyMissionOnTapped;
        TechnologyReserchtap.Tapped += TechnologyReserchOnTapped;
    }
    private void OnDisable()
    {
        backScenetapGesture.Tapped -= backOnTapped;
        WeaponProductiontap.Tapped -= WeaponProductionOnTapped;
        StrategyMissiontap.Tapped -= StrategyMissionOnTapped;
        TechnologyReserchtap.Tapped -= TechnologyReserchOnTapped;
    }
    void Start()
    {

    }
    void Update()
    {

    }
    private void WeaponProductionOnTapped(object sender, EventArgs e)
    {
        
    }
    private void StrategyMissionOnTapped(object sender, EventArgs e)
    {
        
    }
    private void TechnologyReserchOnTapped(object sender, EventArgs e)
    {
        
    }
    private void backOnTapped(object sender, EventArgs e)
    {
        SceneManager.LoadScene(previosSceneName, LoadSceneMode.Single);
    }
}
