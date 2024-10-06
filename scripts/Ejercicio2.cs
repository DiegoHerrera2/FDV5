using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public Button Button;
    private bool buttonPressed = false;

    private void Start()
    {
        transform.LookAt(goal);
        Button.onClick.AddListener(() => buttonPressed = true);
    }

    void Update()
    {
        if (!buttonPressed) return;
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
    }
}