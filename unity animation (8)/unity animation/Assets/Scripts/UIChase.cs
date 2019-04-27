using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChase : MonoBehaviour {

    public GameObject ChaseUI,goladdar;

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			ChaseUI.SetActive(true);
            goladdar.SetActive(true);
        }
	}
}
