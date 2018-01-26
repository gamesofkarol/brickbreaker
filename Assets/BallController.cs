using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Brick2")){
			Destroy(col.gameObject);
		}
	}
}
