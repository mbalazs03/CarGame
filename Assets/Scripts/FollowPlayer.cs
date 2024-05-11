using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject selectedPlayer;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - selectedPlayer.transform.position;
    }

    void LateUpdate()
    {
        transform.position = selectedPlayer.transform.position + offset;    
    }

}
