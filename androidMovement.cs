using UnityEngine;
using System.Collections;

public class androidMovement : MonoBehaviour {

	public Vector2[] loc;


	void Awake(){
		loc = new Vector2[9];
	}


	// Use this for initialization
	void Start () {

		loc [0] = new Vector2 (0, 0);
		loc [1] = new Vector2 (0, -2.8f);
		loc [2] = new Vector2 (0, 3.6f);
		loc [3] = new Vector2 (2.3f,0);
		loc [4] = new Vector2 (-2.3f,0);
		loc [5] = new Vector2 (-2.3f,-2.8f);
		loc [6] = new Vector2 (2.3f,-2.8f);
		loc [7] = new Vector2 (2.3f,3.6f);
		loc [8] = new Vector2 (-2.3f,3.6f);

		InvokeRepeating ("move", 1, 1);

	
	}

	void move(){
		int randLoc = Random.Range (0, 9);
		transform.position = Vector2.Lerp (loc [randLoc], loc [randLoc], Time.deltaTime);
	}
	

}
