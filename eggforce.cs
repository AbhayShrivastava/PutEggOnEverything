using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class eggforce : MonoBehaviour
{
 
  
    private Rigidbody2D rb;
    public float Force;
    public bool egghit;


    // Use this for initialization
    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        egghit = false;


    }

    // Update is called once per frame
    void Update()
    {
      

        if ((egghit == true) && (Input.GetKey(KeyCode.Space) || Input.touchCount > 0 || Input.GetMouseButton(0)))
        {


            rb.AddForce(new Vector2(Force, 0) * Time.deltaTime, ForceMode2D.Force);



        }



    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "pan")
        {

            egghit = true;


        }

        


    }
   




}