using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Vector3 target;

    public int shipSpeed = 5;

    public void SetTarget(Vector3 targPos) 
    {
        target = new Vector3(targPos.x, targPos.y,0);
    }

    void Start()
    {
        target = transform.position;
    }

    void FixedUpdate()
    {
        var moveAttempt = target - transform.position;

        transform.position += moveAttempt.normalized * (Time.deltaTime*shipSpeed);
        if(Vector3.Distance(transform.position,target) < .5f) { transform.position = target; }
    }
}
