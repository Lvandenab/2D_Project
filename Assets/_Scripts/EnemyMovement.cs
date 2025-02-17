using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public BoxCollider2D groundCollider;
    public GameObject player;
    public GameObject DeathMenu;
    public static bool Paused;
    // Update is called once per frame
    void Start()
    {
        DeathMenu.SetActive(false);
        Paused = false;
    }
    void Update()
    {
        if (groundCollider.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(player);
            if (!Paused)
            {

                Time.timeScale = 0.0f;
                DeathMenu.SetActive(true);
                Paused = true;

            }
          
        }
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }

    }*/
    
    

    // Update is called once per frame
    

}
