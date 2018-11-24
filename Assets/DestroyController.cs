using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {

		//Unityちゃんのオブジェクトを取得
		unitychan = GameObject.Find ("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {

		//unityちゃんの後ろに移動したら、消失する
		if (unitychan.transform.position.z > this.transform.position.z + 5){

			//ゲームオブジェクト（自らの消去）
			Destroy (gameObject);

		}
		
	}
}
