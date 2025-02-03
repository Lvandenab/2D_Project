using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public BoxCollider2D groundCollider;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        if (groundCollider.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(player);
        }
    }
    
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }*/
    
}
