using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour {

    static int sceneIndex=3;    // scene to be played


   // public Text Levelno;
   // int levelno;



	// Use this for initialization
	void Start () {
        //  sceneIndex +=1 ;  //scene equals to next  level



       // levelno = 1;

	}
	
	// Update is called once per frame
	void Update () {

        //Levelno.text = "#" + levelno;



		
	}



    public void Next()
    {

        SceneManager.LoadScene(sceneIndex);
        sceneIndex++;





    }


    public void Startgame()
    {
        SceneManager.LoadScene(2);

    }


    public void NextLevel()
    {
       // levelno++;
        sceneIndex++;

    }
    public void Backlevel()
    {
        sceneIndex--;
      //  if (levelno != 0)
        {
       //     levelno--;

        }
        }
    public void GO()
    {
        SceneManager.LoadScene(sceneIndex);
    }





}
