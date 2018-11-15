// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{
    private bool visible = false;
    private Vector3 pos1;
    private Vector3 pos2;
    public Vector3 posDiff = new Vector3(0f, 0f, 20f);
    public float speed = 1.0f;
    void Start()
    {

        pos1 = transform.position;
        pos2 = transform.position + posDiff;
    }
    void OnBecameVisible()
    {
        visible = true;
    }

    // OnBecameInvisible is called when the renderer is no longer visible by any camera. INCLUDING YOUR EDITOR CAMERA
    void OnBecameInvisible()
    {
        visible = false;
    }

    void Update()
    {
        if (!visible)
            move();
    }

    public void move()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        transform.Rotate(Vector3.up * 10f * Time.deltaTime);
    }
}