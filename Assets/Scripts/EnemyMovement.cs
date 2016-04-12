using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    
 
    public float speed;
    private Transform player;
    public float healthPoints;
    private PlayerMovement thePlayer;
    private Stats health;
    public int damage;
    public int scoreValue = 1;

    // Use this for initialization
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        thePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
     
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
        transform.eulerAngles = new Vector3(0, 0, z);

        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }

    // Method called by shots
    void ApplyDamage(float damage)
    {
        if (healthPoints <= damage)
        {
            ScoreManager.score += scoreValue;
            Destroy(gameObject);
           
        }
        else {
            healthPoints -= damage;
            //Debug.Log("Remaining Healthpoints: " + healthPoints);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            thePlayer.Damage(damage);
        }
    }
    
}