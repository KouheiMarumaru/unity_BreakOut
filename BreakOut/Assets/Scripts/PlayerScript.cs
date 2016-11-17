using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	float accel = 70.0f;

	//クラス内　グローバル変数


	void  Update (){
		GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);
		//GetComponentメソッドは、
		//GetComponent<クラス>と記述することによって、
		//指定したクラスのコンポーネントを取り出すことができます。
		//今回の場合は、Playerに付与されているRigidbodyを取得しています。

			//AddForce( 力を加える方向, 力の加え方(ForceMode))
			//AddForceはオブジェクトに対して力を加えるメソッドです。
			//AddForceメソッドは、第1引数に力の大きさと方向を表すベクトルを、第2引数に力の加え方を取ります。

				// transform.right
				//X軸方向(右方)の単位ベクトル。
				//AddForceの引数に指定することによって力を加える方向を指定できます。

				//Input.GetAxisRaw
				//入力されたキーを-1から1までの数値で返すことができます。
				//今回は引数にHorizontalが指定されています。
				//Horizontalに割り当てられているキーが入力された時-1から1までの数値で返すことになります。

				//ForceMode.Impulse
				//AddForceメソッドで指定できる力の加え方。 
				//ForceMode.Impulseは対象のオブジェクトの質量(Mass)を使用して、rigidbodyに瞬時に力を加えます。
			    //オブジェクトの質量(Mass)によって挙動が変化します。


	}
}