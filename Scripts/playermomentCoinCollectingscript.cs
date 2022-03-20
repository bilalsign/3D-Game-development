using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectingscript : MonoBehaviour
{
    
    public float speed;
   private void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        transform.Translate(mov * Time.deltaTime);
    }
}
