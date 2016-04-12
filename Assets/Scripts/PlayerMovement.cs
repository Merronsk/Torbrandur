using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {
    
    
    [SerializeField]
    private Stats health;

    public GameObject weapon;
    public float speed;
    public float shootdelay;
    private float lastshoot = 0;
   
    private void Awake()
    {
        health.Initiliaze();
    }
   
    // Update is called once per frame
    void Update() {
        if(health.CurrentVal > health.MaxValue)
        {
            health.CurrentVal = health.MaxValue;
        }
        if(health.CurrentVal <= 0)
        {
            Die();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            health.CurrentVal += 10;
        }
        // Rotate Player around the cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

        // Move the player
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * Time.deltaTime * speed;
        if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0)) {
            GetComponent<Animator>().SetBool("isWalking", true);
        } else {
            GetComponent<Animator>().SetBool("isWalking", false);
        }

        // Fire when mouse1 is pressed
        if (Input.GetButtonDown("Fire1")) {
            if (Time.time > (lastshoot + shootdelay)) {
                GameObject shot = (GameObject) Instantiate(weapon, transform.position, Quaternion.identity);
                shot.transform.rotation = transform.rotation;
                lastshoot = Time.time;
            }
        }
    }
    public void Die()
    {
        SceneManager.LoadScene("Scene");
    }
    public void Damage(int damage)
    {
        health.CurrentVal -= damage;
    }
}
