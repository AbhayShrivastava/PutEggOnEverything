using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class managerslot : MonoBehaviour {

	public UI ui;
    public slot_Random slot;


   

    



  
    void gameover()
    {

        ui.gameOverActivated = true;
        slot.leverdown = true;




    }

   






        void OnCollisionStay2D(Collision2D col)
        {

            if (col.gameObject == true)
            {

            gameover();





            }


        }



    }









