using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILadder : MonoBehaviour
{
    public GameObject LadderUI;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            LadderUI.SetActive(true);
        }
    }
}
