using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour {

    public GameObject TagRedPrefab;
    public GameObject TagYellowPrefab;
    public GameObject TagGreenPrefab;
    public GameObject TagBlackPrefab;
    public GameObject RescueBreathsPrefab;
    public GameObject PulsePrefab;
    public GameObject PositionAirwayPrefab;
    public GameObject PerfusionPrefab;
    public GameObject MentalStatusPrefab;
    public GameObject CheckBreathingPrefab;

    float bulletImpulse = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Camera cam = Camera.main;
        if ( Input.GetButtonDown("TagRed") ) {
			GameObject TagRedBullet = (GameObject)Instantiate(TagRedPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			TagRedBullet.GetComponent<Rigidbody>().AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
		}

        else if (Input.GetButtonDown("TagYellow"))
        {
            GameObject TagYellowBullet = (GameObject)Instantiate(TagYellowPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            TagYellowBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("TagGreen"))
        {
            GameObject TagGreenBullet = (GameObject)Instantiate(TagGreenPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            TagGreenBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("TagBlack"))
        {
            GameObject TagBlackBullet = (GameObject)Instantiate(TagBlackPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            TagBlackBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("CheckBreathing"))
        {
            GameObject CheckBreathingBullet = (GameObject)Instantiate(CheckBreathingPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            CheckBreathingBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("PositionAirway"))
        {
            GameObject PositionAirwayBullet = (GameObject)Instantiate(PositionAirwayPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            PositionAirwayBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("Perfusion"))//only for adults, aka cappilary refill
        {
            GameObject PerfusionBullet = (GameObject)Instantiate(PerfusionPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            PerfusionBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("MentalStatus"))
        {
            GameObject MentalStatusBullet = (GameObject)Instantiate(MentalStatusPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            MentalStatusBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("Pulse"))//only for children
        {
            GameObject PulseBullet = (GameObject)Instantiate(PulsePrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            PulseBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }

        else if (Input.GetButtonDown("RescueBreaths"))//only for children
        {
            GameObject RescueBreathsBullet = (GameObject)Instantiate(RescueBreathsPrefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            RescueBreathsBullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }
    }
}
