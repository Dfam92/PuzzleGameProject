using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float speed;
   

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlayerMovement()
    {
        
        float vInput = Input.GetAxis("Vertical");
        
        playerRb.AddForce(Camera.main.transform.up * vInput * speed);
        
       
    }
}
