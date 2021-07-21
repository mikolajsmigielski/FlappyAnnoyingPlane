using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform TracedObject;
    public float DeltaX;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(TracedObject.position.x + DeltaX, transform.position.y, transform.position.z);
    }
}
