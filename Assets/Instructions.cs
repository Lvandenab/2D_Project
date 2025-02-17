using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject Menu;
    void Start()
    {
        Menu.SetActive(false);
    }
    public void Onclick()
    {
        Menu.SetActive(true);
            

    }
}
