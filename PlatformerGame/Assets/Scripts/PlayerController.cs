using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement Variables 
    Rigidbody2D rb;
    public float jumpForce;
    public float speed;

    //Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbpdy2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 newPosition = transform.position;

       //Variables to mirror player
       Vector3 newScale = transform.localScale;
       float currentScale = Mathf.Abs(transform.localScale.x); //take absolute value of the current x scale  
   
   
     if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
     {
        newPosition.x -= speed;
        newScale.x =- currentScale;
     }
   
   
   
   
    }
}
