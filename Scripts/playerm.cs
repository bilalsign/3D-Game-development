using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerm : MonoBehaviour
{

    public float speed =10f;
    public Rigidbody rb;
    public bool cubeIsOnTheGround = true;

    private void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0 , vertical);
        
        if(Input.GetButtonDown("Jump") && cubeIsOnTheGround){
        rb.AddForce(new Vector3(0,10,0),ForceMode.Impulse);
        cubeIsOnTheGround = false;
    }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground"){
            cubeIsOnTheGround = true;
        }
    }
}
