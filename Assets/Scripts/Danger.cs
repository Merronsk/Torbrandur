using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Danger : MonoBehaviour {

    private PlayerMovement thePlayer;
    private Stats health;
    public int damage;

    void Start()
    {
        thePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            thePlayer.Damage(damage);
        }
    }
	}

