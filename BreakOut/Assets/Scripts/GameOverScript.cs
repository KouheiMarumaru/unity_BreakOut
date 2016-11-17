using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void  OnGUI (){

		GUIStyle guiStyle = new GUIStyle();
		//フォントサイズを設定するプロパティはGUIStyleクラスのものなので、
		//GUIStyleクラスのインスタンスを生成しています。
		//生成したインスタンスをGUIStyle型変数guiStyleに代入しています。

		GUIStyleState styleState = new GUIStyleState();
		//テキストカラーを設定するプロパティはGUIStyleStateクラスのものなので、
		//GUIStyleStateクラスのインスタンスを生成しています。
		//生成したインスタンスをGUIStylestate型変数styleStateに代入しています。

		styleState.textColor = Color.black;
		//テキストカラーを設定しています。
		//今回はblackに設定します。
		//GUIStyleStateクラスのインスタンスに対して
		//textColorプロパティを使用することでテキストカラーを設定できます。

		guiStyle.normal = styleState;
		//テキストカラーをguiStyleに反映させるための記述

		guiStyle.fontSize = 120;
		//フォントサイズを設定しています。
		//GUIStyleクラスのインスタンスに対して
		//fontSizeプロパティを使用することでフォントサイズを設定

		GUI.Label( new Rect(10, 10, 300, 100), "Game Over !!", guiStyle);
		//(x, y, width, hight) = (10, 10, 300, 100)の位置にGameOverという文字を表示

	}

}