using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothspeed;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -0f, 19.8f),
            Mathf.Clamp(transform.position.y, -0f, 0f),
            transform.position.z);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 positioncamera = target.localPosition + offset;
        Vector3 smoothCamera = Vector3.Lerp(transform.position, positioncamera, smoothspeed);
        transform.position = smoothCamera;
    }
}
