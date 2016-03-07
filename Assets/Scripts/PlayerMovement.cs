using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public GameObject weapon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Vector3 shootDirection = Input.mousePosition;
            shootDirection.z = 0.0f;
            shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
            shootDirection = shootDirection - transform.position;
            //Debug.Log(shootDirection.x + " - " + shootDirection.y + " - " + shootDirection.z);
            //transform.position += new Vector3(shootDirection.x, shootDirection.y);
            GameObject bullet = (GameObject) Instantiate(weapon, transform.position, Quaternion.identity);

            //Debug.Log(
        }
	
	}
}
