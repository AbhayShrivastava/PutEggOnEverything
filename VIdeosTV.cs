using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VIdeosTV : MonoBehaviour {

    public UI UI;


    private VideoPlayer Video;




    public VideoClip changedVideo;
    // Use this for initialization

    private void Awake()
    {
        Video = GetComponent<VideoPlayer>();
        
    }

    void Start () {





	}
	
	// Update is called once per frame
    void Update () {

        if (UI.gameOverActivated == true)
        {


            Video.clip = changedVideo;
            Video.Prepare();
            if (Video.isPrepared==true)
            {
                Video.Play();
            }

        }



	}
}
