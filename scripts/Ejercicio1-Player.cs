using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public ThirdPersonController controller;
    public Toggle toggle;
    private int score = 0;
    public TMP_Text text;

    private void Start()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }
    
    private void OnToggleValueChanged(bool value)
    {
        controller.MoveSpeed = value ? 3.0f : 1.0f;
    }
    
    public void OnObjectCollected(bool isBad)
    {
        Debug.Log("Object collected!");
        score++;
        text.text = score.ToString();
        if (isBad)
        {
            controller.MoveSpeed = 0.1f;
        }
    }
}
