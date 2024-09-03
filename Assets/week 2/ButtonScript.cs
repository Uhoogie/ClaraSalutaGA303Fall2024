using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public Light coollightobject;

    void Start()
    {
        TaskOnClick();
    }

    
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        
        coollightobject.intensity = 25f;
        coollightobject.range = 35f;
        coollightobject.color = Color.blue;
    }


}
