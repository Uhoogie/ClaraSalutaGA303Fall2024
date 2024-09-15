using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public int counter = 0;
         public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           counter += 1;

           if (counter >= 5) 
           Debug.Log("Are you proud now?");
    {
        Debug.Log("Now it's the end...");
        NextScene();
    }
        }
    }
     

 public void NextScene()
    {
        SceneManager.LoadScene("End of the World");
    }

}
