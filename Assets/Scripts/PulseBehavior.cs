using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseBehavior : MonoBehaviour {

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
            Destroy(gameObject);//does not work for adults

        }
        else if (collision.gameObject.tag == "Child")
        {
            Destroy(gameObject);
            print(collision.gameObject.GetComponent<ChildObject>().CheckPulse());//printing untill we implement something else
        }
    }
}
