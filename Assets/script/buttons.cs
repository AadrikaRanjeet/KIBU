using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour
{
    public void PlayGame()
    {
        //load the next level
       //SceneManager.LoadScene(1);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
