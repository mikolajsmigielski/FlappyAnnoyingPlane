using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovment : MonoBehaviour
{
    public float FlyingAngle = 60f;
    public float FallAngle = -80f;
    public float CurrentAngle = 0f;
    public float Speed = 2f;
    // Update is called once per frame
    void Update()
    {
        var TargetAngle = Input.GetKey(KeyCode.Space) ? FlyingAngle : FallAngle;
        CurrentAngle = Mathf.Lerp(CurrentAngle, TargetAngle, Time.deltaTime * 2f);
        transform.rotation = Quaternion.Euler(Vector3.forward * CurrentAngle);
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
