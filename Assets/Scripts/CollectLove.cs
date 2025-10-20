using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLove : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("Player"))
        {
            LoveController.instance.FillLove();
            Destroy(gameObject);
        }
    }
}
