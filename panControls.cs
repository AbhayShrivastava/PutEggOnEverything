using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EazyTools.SoundManager;



public class panControls : MonoBehaviour {





    public AudioClip  endclip;

    private Rigidbody2D rb;
	float forceAmount=90f;




	void Awake()
	{

		rb = GetComponent<Rigidbody2D> ();

       
	}


	
    void FixedUpdate () {

		if (Input.GetKey (KeyCode.Space) || Input.touchCount > 0 || Input.GetMouseButton(0)) {


			rb.AddTorque (forceAmount, ForceMode2D.Impulse);

        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="egg")

        {
            SoundManager.PlayMusic(endclip, 0.8f, false, true, 0.2f, 0.8f);

        }
    }







}
