using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class managership : MonoBehaviour {

	public UI ui;
   



    private Animation Ship;



    private void Awake()
    {

        Ship = GetComponentInParent<Animation>();
    }


    private void Start()
    {
        Ship.Play("ship");
    }



    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject == true)
        {

            ui.gameOverActivated = true;


            Ship.PlayQueued("shipbreak");




        }


    }



		
		
		}


	



