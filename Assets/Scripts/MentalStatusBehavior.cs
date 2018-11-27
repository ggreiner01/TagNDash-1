using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalStatusBehavior : MonoBehaviour {

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
            if (collision.gameObject.GetComponent<AdultObject>().CanUnderstand())//printing untill we implement sounds
            {
                print("The patient can understand\n");
                if (collision.gameObject.GetComponent<AdultObject>().CanRespond())
                {
                    print("The patient can respond\n");
                }
            }
        }
        else if (collision.gameObject.tag == "Child")
        {
            Destroy(gameObject);
            if (collision.gameObject.GetComponent<ChildObject>().CanUnderstand())//printing untill we implement sounds
            {
                print("The patient can understand \n");
                    if (collision.gameObject.GetComponent<ChildObject>().CanRespond())
                {
                    print("The patient can respond\n");
                }
            }
        }
    }
}
