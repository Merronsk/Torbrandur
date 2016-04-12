﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    [SerializeField]
    private Color fullColor;

    [SerializeField]
    private Color lowColor;

    [SerializeField]
    private float lerpSpeed;

    private float fillAmount;

    [SerializeField]
    private Image content;

    [SerializeField]
    private Text ValueText;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            string[] tmp = ValueText.text.Split(':');
            ValueText.text = tmp[0] + ": " + value;
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HandleBar();
        
	}
    private void HandleBar()
    {
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }

        content.color = Color.Lerp(lowColor, fullColor, fillAmount);
        
    }
    private float Map(float value, float inMin,float inMax,float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
