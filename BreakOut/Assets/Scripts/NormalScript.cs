using UnityEngine;
using System.Collections;

public class NormalScript : MonoBehaviour {

	public GameManager gameManager;

	void  OnCollisionEnter (){
		Destroy(gameObject);
		gameManager.score += 10;
	}


	//OnCollisionEnter
	//OnCollisionEnter内で定義された処理は、
	//他のオブジェクトに衝突した際に呼び出されます。
	//今回の場合は、BallがNormalBlockに衝突した際に「Destroy(gameObject);」が呼び出されます。

	//Destroyメソッド
	//Destroyメソッドは、引数に指定したものを削除します。
	//今回の場合は、Destroy(gameObject);のgameObjectの部分にGameObjectであるNormalBlockが入ります。
	//これにより、 NormalBlockが削除されます。
}