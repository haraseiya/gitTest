using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDoor2 : MonoBehaviour {

    public GameObject DoorUI;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            DoorUI.SetActive(true);
        }
    }

}
