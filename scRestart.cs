using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scRestart : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "egg")
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
