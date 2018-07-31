using System;
using TouchScript.Gestures;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    public TapGesture tapGesture;

    private void OnEnable()
    {
        tapGesture.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        tapGesture.Tapped -= OnTapped;
    }

    private void OnTapped(object sender, EventArgs e)
    {
        Debug.Log("タップされた");
    }
}