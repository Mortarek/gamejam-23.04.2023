using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Newpos = new Vector3(target.position.x, target.position.y + yOffset, -1);
        transform.position = Vector3.Slerp(transform.position, Newpos, FollowSpeed * Time.deltaTime);
    }
}
