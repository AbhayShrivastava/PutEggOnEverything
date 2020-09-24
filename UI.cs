using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class UI : MonoBehaviour {


	
    public bool gameOverActivated;  // whether egg collide with object


    public float timer = 1.5f; //timelimit egg  should be on objects

    public TakeScreenshot SS;//reference to Screenshot class





    
    void Start()
	{
		gameOverActivated = false;



    }



    void Update()
	{
      


        if (gameOverActivated==true)
        {

          



            timer -= Time.deltaTime;

          if (timer<1)
            {
                SS.TakeAShot();
            }


            if (timer<0)
            {
               
                LevelManager();


            }






        }




     





    }




    void LevelManager()
    {
        if (gameOverActivated == true)
        {


          

            SceneManager.LoadScene("screenshot");
          

            






        }




    }

	

		



	}

		





















	

