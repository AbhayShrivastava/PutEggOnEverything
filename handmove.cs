using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handmove : MonoBehaviour {

	public float handSpeed;






	private Animation anim;
	private HingeJoint2D hg;


	// Use this for initialization
	void Awake () 
	{
		anim = GetComponent<Animation> ();
		hg = GetComponentInChildren<HingeJoint2D> ();


	
	}





	
	// Update is called once per frame
	void Update () 
	{
		

			transform.Translate (new Vector2 (1, 0) * handSpeed * Time.deltaTime);


		if (transform.position.x > -4f) {
		
			handSpeed = 0;
		}


			if ((transform.position.x>-4f) && (Input.touchCount > 0 || Input.GetKey (KeyCode.Mouse0) || Input.GetKey (KeyCode.Space))) 
		  {
			
				anim.Play ();
			Destroy (hg);
			anim.PlayQueued("handback");
				

			}
		
		
		

		
		}

		
}








	

		
			
		

		

	

