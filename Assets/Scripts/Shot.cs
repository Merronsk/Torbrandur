using UnityEngine;
using System.Collections;
using System;

public class Shot : MonoBehaviour {

    public float speed;
    public float lifeTime = 1;
    public float damage;
    private float lifeBegun;

    // Use this for initialization
    void Start () {
        lifeBegun = Time.time;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Time.time > (lifeBegun + lifeTime)) {
            Destroy(gameObject);
        } else {
            float rot = transform.eulerAngles.z;
            transform.position += new Vector3(-(float) Math.Sin(degreeToRadian(rot)) * speed * Time.deltaTime,
                (float) Math.Cos(degreeToRadian(rot)) * speed * Time.deltaTime);
        }
    }

    // Collision with another object
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Enemy") {
            coll.SendMessage("RecieveDamage", damage);
            Destroy(gameObject);
        }
    }

    // Calculate degrees to radians
    private float degreeToRadian(float degree) {
        return (float) ((Math.PI / 180) * degree);
    }
}
