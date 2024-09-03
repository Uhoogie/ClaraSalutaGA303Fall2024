using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class lifetimeevent : MonoBehaviour

{

    public float speed = 1600f;
    // Start is called before the first frame update
    public Light coollightobjects;
    void santaclaus() //my own function
    {
        Debug.Log("SANTA!");
    }
    public void Start()
    {
        santaclaus(); //makes my function run at start but it can be put into any of the void junk
    }

    public void Awake()
    {
        //awake is called before start
    }

    // Update is called once per frame
    public void Update()
    {
        checkinputs();
    }

    void checkinputs()
    {
      

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            Debug.Log("You held button went w");

            coollightobjects.color = Color.blue;
            Debug.Log("Wow u pressed the button now blue");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed* -1);
            Debug.Log("You held button went s");

            coollightobjects.color = Color.red;
            Debug.Log("Wow u pressed the button now red");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            Debug.Log("You held button went d");

            coollightobjects.color = Color.green;
            Debug.Log("Wow u pressed the button now green");
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * -1);
            Debug.Log("You held button went a");

            coollightobjects.color = Color.yellow;
            Debug.Log("Wow u pressed the button now yellow");
        }

    }

    //    void LateUpdate()
    //    {
    //        //updates frame after update
     //   }

    //    void FixedUpdate()
    //    {
            //updates every 30frames
    //    }

    //    void OnEnable()
    //    {
    //        Debug.Log("object is enabled"); //will show up on start if object is active is scene on start. then also if object is tuned on and off
     //   }

    //    void OnDisable()
   //     {
    //        Debug.Log("object is disabled");
    //    }

        
    }
