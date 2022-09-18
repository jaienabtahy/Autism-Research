using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject thePlayer;
    public float targetDistance;
    public float allowedDistance = 5;
    public GameObject theNPC;
    public float followSpeed;
    public RaycastHit Shot;


    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            targetDistance = Shot.distance;
            if (targetDistance >= allowedDistance)
            {
                followSpeed = 0.005f;
                theNPC.GetComponent<Animation>().Play("walk");
                transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, followSpeed);
            }
            else
            {
                followSpeed = 0;
                theNPC.GetComponent<Animation>().Play("idle");
            }
        }
    }
}
