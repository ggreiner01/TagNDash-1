using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTagBehavior : MonoBehaviour {

    float lifespan = 1.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifespan -= Time.deltaTime;

        if (lifespan <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Adult")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<AdultObject>().SetTagGussed("Red");
            //use this to test if the object detection is working
            //print(collision.gameObject.GetComponent<AdultObject>().GetTagGussed());
        }
        else if (collision.gameObject.tag == "Child")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<ChildObject>().SetTagGussed("Red");
        }
    }
}
