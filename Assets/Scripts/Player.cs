using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    [SerializeField]
    private Stats health;

    private void Awake()
    {
        health.Initiliaze();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            health.CurrentVal += 10;
        }
    }
}
