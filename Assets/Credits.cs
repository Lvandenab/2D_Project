using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update

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
