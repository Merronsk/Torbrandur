using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Stats
{   [SerializeField]
    private HealthBar healthBar;
    [SerializeField]
    private float maxValue;
    [SerializeField]
    private float currentVal;

    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {
            currentVal = Mathf.Clamp(value, 0, MaxValue);
            healthBar.Value = currentVal;
        }
    }

    public float MaxValue
    {
        get
        {
            return maxValue;
        }

        set
        {
            maxValue = value;
            healthBar.MaxValue = maxValue;
        }
    }
    public void Initiliaze()
    {
        this.MaxValue = maxValue;
        this.CurrentVal = currentVal;
    }
}
