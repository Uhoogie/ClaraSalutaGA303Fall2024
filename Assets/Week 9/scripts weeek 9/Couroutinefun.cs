using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Couroutinefun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WaitAndPostDebug();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator WaitAndPostDebug()
    {

        Debug.Log("Start  of couroutine");

        yield return null; // waits for next frame

        yield return new WaitForSeconds (4); //waits a few seconds

        Debug.Log("end of this coroutine");
    }

    public float returennumber() 
    {
        return 5f;
    }
}
