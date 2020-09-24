using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class manager : MonoBehaviour 
{

    public UI ui;//reference to ui script


   

 // egg colliding with gameobjects

    void OnCollisionStay2D(Collision2D col)
	{

        if (col.gameObject==true )  
        {

            ui.gameOverActivated = true;

            


         
        }


	}





	}






