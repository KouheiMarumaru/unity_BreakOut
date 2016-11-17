using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	float speed = 15.0f;

	void  Update (){
		//条件1
		//JUMPに割り振られているキー(spaceキー)が離された瞬間

		//条件2
		//Ballの速度オブジェクトが(X, Y, Z) = (0, 0, 0)のとき、つまり静止している時
		//上記の2つの条件がtrueを返す時

		//&& どちらも
		if (Input.GetButtonUp("Jump") && GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0)){
			GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
		}

		//input get key

		//GetButtonUp
		//押しているキーを離した瞬間にtrueを返します。

		// Vector3
		//オブジェクトの位置や速度をVector3を用いて表現します。
		//Vector3ではX, Y, Zの3方向におけるベクトルの大きさ(速度)や位置、回転を指定できます。
	}

	//追記
	void  OnCollisionEnter (){

		//Rigidbody型
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = rigidbody.velocity.normalized * 15;
	}
}