using UnityEngine;
using System.Collections;

public class HardScript : MonoBehaviour {

	public GameManager gameManager;
	int hp = 2;

	void  OnCollisionEnter (){

		//デクリメント演算子
		hp--;

		if (hp == 0){
			Destroy(gameObject);
			gameManager.score += 20;
		}
	}
}