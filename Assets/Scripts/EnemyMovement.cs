using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    public float speed;
    private Transform player;
    public float healthPoints;

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() {
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        transform.eulerAngles = new Vector3(0, 0, z);
        
        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }

    // Methed called by shots
    void ApplyDamage(float damage) {
        if (healthPoints <= damage) {
            Destroy(gameObject);
        } else {
            healthPoints -= damage;
            //Debug.Log("Remaining Healthpoints: " + healthPoints);
        }
    }
}
