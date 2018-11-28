// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{
    Animator anim;
    private bool visible = false;
    private Vector3 pos1;
    private Vector3 pos2;
    public Vector3 posDiff = new Vector3(0f, 0f, 5f);
    public float speed = 1.0f;
    public string TagGiven = "";
    public Transform target;
    public Transform Player;
    void Start()
    {
        anim = GetComponent<Animator>();
       
        pos1 = transform.position;
        pos2 = transform.position + posDiff;
    }
    void Update()
    {
        float dist = Vector3.Distance(transform.position, Player.position);
        if (gameObject.tag == "Adult")
        {
            TagGiven = gameObject.GetComponent<AdultObject>().GetTagGussed();

        }
        else if (gameObject.tag == "Child")
        {
            TagGiven = gameObject.GetComponent<ChildObject>().GetTagGussed();

        }
        if (dist >= 3 && TagGiven != "Green")
            move();
        else if (dist <= 3 && TagGiven != "Green")
        {
            anim.Play("HumanoidIdle");
            transform.LookAt(Player.position);
        }
        else if (TagGiven == "Green" && transform.position != target.position)
            goTowards();
        else if (transform.position == target.position)
            anim.Play("HumanoidIdle");
        
    }

    public void move()
    {
        anim.Play("Run");
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        float dist1 = Vector3.Distance(pos1, transform.position);
        float dist2 = Vector3.Distance(transform.position, pos2);
        if (dist1 < 0.8)
        {
            transform.LookAt(pos2);
        }
        if (dist2 < 0.8)
        {
            transform.LookAt(pos1);
        }
    }
    public void goTowards()
    {
        anim.Play("Run");
        transform.LookAt(target.position);
        float step = 2.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}