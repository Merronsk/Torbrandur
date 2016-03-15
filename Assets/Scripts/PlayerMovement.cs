using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public GameObject weapon;
    public float speed;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        //Rotate Player around the cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * Time.deltaTime * speed;

        //Fire when mouse1 is pressed
        if (Input.GetButtonDown("Fire1")) {
            GameObject shot = (GameObject) Instantiate(weapon, transform.position, Quaternion.identity);
            shot.transform.rotation = transform.rotation;
        }

    }
}
