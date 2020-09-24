using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class manageregg : MonoBehaviour {

    public UI ui;


    public GameObject egg;


    public AudioSource Audio;




    //private Animator zombie;



    void gameover()
    {

        ui.gameOverActivated = true;

        egg.SetActive(true);
        Audio.Play();

    }
  






        void OnCollisionStay2D(Collision2D col)
        {

            if (col.gameObject == true)
            {

            gameover();




            }


        }



    }










