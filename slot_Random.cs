using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot_Random : MonoBehaviour
{

    Animator anim;
    public bool leverdown=false;
    public GameObject[] objects;

    



    private void Awake()
    {
        anim = GetComponent<Animator>();

    }


    private void Update()
    {

        if (leverdown==true)

        {
            anim.SetBool("gameon", true);
            
            foreach(GameObject @object in objects)
            {
                @object.SetActive(true);

            }

        }
    }



}

	
    

    

