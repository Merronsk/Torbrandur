using UnityEngine;
using System.Collections;

public class Instantiator : MonoBehaviour {

    public GameObject obj;
    public float interval;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    private float lastSpawn;

	// Use this for initialization
	void Start () {
        lastSpawn = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Time.time > (lastSpawn + interval)) {
            float xLoc = Random.Range(minX, maxX);
            float yLoc = Random.Range(minY, maxY);
            Instantiate(obj, new Vector3(xLoc, yLoc), Quaternion.identity);
            lastSpawn = Time.time;
        }
	}
}
