using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    [SerializeField] private float speed;
    public GameObject target;
    public Rigidbody cameraRb;
   

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        //CameraHorizontalMovement();
    }
    private void CameraHorizontalMovement()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.RotateAround(target.transform.position, Vector3.up, hInput*speed);
    }
}
