using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private GameObject gm;
    
    private void Start()
    {
        gm = GameObject.Find("Game Manager");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("coin");
        gm.GetComponent<GameManager>().CoinPickedUp();
        Destroy(this.gameObject);
    }
}
