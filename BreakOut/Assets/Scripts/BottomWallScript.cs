using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BottomWallScript : MonoBehaviour {

	//引数を設定しないと、ボールに当たると（ボールからの衝突判定で）BottomWallそのものが消える

	//衝突してきたものに対してDestroyしたい。
	//関数(メソッド)OnCollisionEnter内部で処理するために、衝突してきたものの引数を受け取り、
	//Collision型の変数collisonを引数として設定


	public GameManager gameManager;
	public GameObject ballPrefab;
	Vector3 placePosition = new Vector3(0f, 0.6f, -7f);
	//Ballオブジェクトを複製するPositionを指定するために定義
	//どうやって決めているのか？

	void  OnCollisionEnter ( Collision collision ){
		Destroy(collision.gameObject);
		//collision(ぶつかってきたもの)のgameObjectを削除する

		if (gameManager.life > 0) {

			Instantiate (ballPrefab,placePosition,Quaternion.identity);
			//Instantiate (複製するオブジェクト, 複製する位置, 複製するオブジェクトの回転);
			//引数に既存のオブジェクトを指定することで、そのオブジェクトを複製

			//Quaternion.identityは回転を親オブジェクトの回転座標と同じにします
			//親オブジェクトが存在していない場合は
			//Rotationを(x,y,z)= (0,0,0)に変更します。
			//今回の場合は複製したBallオブジェクトのRotationを(x, y, z) = (0, 0, 0)にしています。

			//Quaternion...回転を表すもの

			gameManager.life--;
		} 

		else if (gameManager.life == 0){
			SceneManager.LoadScene("GameOver");
			//引数に指定したシーンを呼び出します
		}

	}
}