using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public ThirdPersonController controller;
    public UIDocument toggle;
    private int score = 0;
    public TMP_Text text;

    private void Start()
    {
        //toggle.onValueChanged.AddListener(OnToggleValueChanged);
        toggle.rootVisualElement.Q<Toggle>("Toggle").RegisterCallback<ChangeEvent<bool>>(evt => OnToggleValueChanged(evt.newValue));
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
