using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //シーンの切り替え
    public void ChangeScene()
    {
        //指定した名前のシーンに切り替える
        SceneManager.LoadScene("SampleScene");
    }
    //ボタンテスト
    public void ButtonTest()
    {
        Debug.Log("ボタンが押されたよ！");
    }
}
