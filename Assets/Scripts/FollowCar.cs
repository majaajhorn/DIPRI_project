using System;
using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform target;       // The car
    public Vector3 offset = new Vector3(0, 3, -6);  // Position behind and above, ovo radi sa plavim autom
    //public Vector3 offset = new Vector3(0, 3, 6);

    public Vector3[] offsets;
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;
        //offset = offsets[trenit_index]
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        //Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);  // Always look at the car
    }

}
