using UnityEngine;
using System.Collections;

public class ParamScript : MonoBehaviour {

	public GameManager gameManager;
	public GUIStyle guiStyle;

	void  OnGUI (){
		//Rect関数を用いてラベルを表示する為の座標と大きさを記述
		//Rect関数は、x、y、幅、高さの4つの値によって定義される2次元の範囲
		Rect position1 = new Rect (10, 10, 200, 40);
		Rect position2 = new Rect (10, 50, 200, 40);
		Rect position3 = new Rect (10, 120, 200, 40);
		Rect position4 = new Rect (10, 160, 200, 40);

		//GUI.Label ( new Rect(X座標, Y座標, 幅, 高さ), 表示させる文字, 表示スタイル);
		GUI.Label ( position1, "スコア", guiStyle);
		GUI.Label ( position2, gameManager.score.ToString(), guiStyle);
		GUI.Label ( position3, "残機数", guiStyle);
		GUI.Label ( position4, gameManager.life.ToString(), guiStyle);
	}
}