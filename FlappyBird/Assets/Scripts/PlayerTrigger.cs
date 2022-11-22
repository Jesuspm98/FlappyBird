using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            OnPlayerEnter(collision.gameObject);
        }
    }

    public virtual void OnPlayerEnter(GameObject collision)
    {
    }
}