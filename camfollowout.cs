using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollowout : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 10f;

    private void FixedUpdate()
    {

        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * smoothspeed);

    }

    private void Update()
    {
        transform.position = target.position;
    }

}
