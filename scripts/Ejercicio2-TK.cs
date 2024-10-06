using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonHandler : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public UIDocument Button;
    private bool buttonPressed = false;

    private void Start()
    {
        transform.LookAt(goal);
        Button.rootVisualElement.Q<Button>("Boton").RegisterCallback<ClickEvent>(evt => buttonPressed = true);
    }

    void Update()
    {
        if (!buttonPressed) return;
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
    }
}