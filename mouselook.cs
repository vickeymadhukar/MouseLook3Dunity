using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float sensi = 100f;
    public float mousesensi = 10f;
    float xrotation =0f;
    public Transform body;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X")*mousesensi*Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y")*mousesensi*Time.deltaTime;
        xrotation -= mousey;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        body.Rotate(Vector3.up * mousex);

    }
}
