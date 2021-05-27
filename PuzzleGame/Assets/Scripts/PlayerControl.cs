using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody playerRb;
    [SerializeField] private float speed;
    public GameObject cameraPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
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
        Vector3 mousePos = Input.mousePosition;
        transform.position = mousePos;
        /*float vInput = Input.GetAxis("Vertical");
        float hInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(cameraPlayer.transform.up * vInput * speed);
        playerRb.AddForce(cameraPlayer.transform.right * hInput * speed);*/
       
    }
}
