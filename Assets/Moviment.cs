using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public Camera cam;
    public Transform cube;
    public float distanceFromCamera;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        distanceFromCamera = Vector3.Distance(cube.position, cam.transform.position);
        rb = cube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = distanceFromCamera;
            pos = cam.ScreenToWorldPoint(pos);
            rb.velocity = (pos - cube.position) * 20;
        }
    }
}
