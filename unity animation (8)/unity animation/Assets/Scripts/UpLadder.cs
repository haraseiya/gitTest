using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpLadder : MonoBehaviour
{

	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E))
		{
			SceneManager.LoadScene("Ladder");
		}
	}
}
