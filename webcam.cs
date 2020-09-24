using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webcam : MonoBehaviour 


{
    WebCamDevice frontcam;
    static WebCamTexture webCam;
    float angle;



	IEnumerator CAM()
	{


		WebCamDevice[] devices = WebCamTexture.devices;
        webCam = new WebCamTexture();
        foreach (WebCamDevice webCamDevice in devices) 
		{

            if (webCamDevice.isFrontFacing == true) 
            {

                frontcam = webCamDevice;
                webCam.deviceName=frontcam.name;
                webCam.requestedHeight = Mathf.RoundToInt(transform.localScale.y * 2);
                    webCam.requestedWidth = Mathf.RoundToInt(transform.localScale.x*2);
              
                            webCam.Play();



            }
                
			





			

		}
		yield return new WaitForEndOfFrame ();
	}


    void Awake()
    {
        StartCoroutine("CAM");


        GetComponent<Renderer>().material.mainTexture = webCam;

    }
	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Player") {


                webCam.Pause();
		}
	
	
	
	
	
	}




		
}
	



	

































