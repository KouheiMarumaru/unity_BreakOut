using UnityEngine;
using System.Collections;

public class PenetrateScript : MonoBehaviour {

	public GameManager gameManager;

	void  OnTriggerEnter (){
		Destroy (gameObject);
		gameManager.score += 10;
		// X += Y
		// XにYを足す
	}
}