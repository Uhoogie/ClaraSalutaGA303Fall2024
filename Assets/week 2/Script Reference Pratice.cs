using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReferencePratice : MonoBehaviour
{
    // Start is called before the first frame update
    public Compoentfun ourotherscript;
    public Light coollightobject;
    public void Start()
    {
        ourotherscript.counter++; //adds 1 to the counter when game starts
        //ourotherscript.myName = "Clara Saluta";


        coollightobject.intensity = 25f;
        coollightobject.range = 35f;
        coollightobject.color = Color.blue;
        Debug.Log("Wow u pressed the button");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        
    }
}
