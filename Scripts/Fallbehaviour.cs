using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallbehaviour : MonoBehaviour
{
  public float fallMutliplayer = 2.5f;
  public float lowMultiplayer = 2f;

  Rigidbody2D rb;
  void Awake(){
      rb.GetComponent<Rigidbody2D>();
  }
    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y<0){
            rb.velocity += Vector2.up * Physics2D.gravity.y* (fallMutliplayer-1) *Time.deltaTime;
        }
        else if (rb.velocity.y >0 && !Input.GetButton("Jump")){
             rb.velocity += Vector2.up * Physics2D.gravity.y* (lowMultiplayer-1) *Time.deltaTime;

        }
    }
}
