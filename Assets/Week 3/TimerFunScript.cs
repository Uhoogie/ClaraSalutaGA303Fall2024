using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimerFunScript : MonoBehaviour
{
    public float timerCountingUp = 0f; //current time
    public float timerDuration = 3f; //time we need to wait before timer finishes
    public bool iscountingup = true; //determines if it should be going up or down
    void Start()
    {

    }

    void Update()
    {

        if (iscountingup == true) //controls it going up
        {
            timerCountingUp += Time.deltaTime; //has the timer count up
        }

        else if (iscountingup == false) //has the timer count down
        {
            timerCountingUp -= Time.deltaTime; //timer count down
        }

        if (timerCountingUp >= timerDuration) //once it hits 3 or is greater than 3 it goes to 0
        {
            this.transform.position += Vector3.right; //transforms it so it goes right when time is reached
            Debug.Log("timer has reached 3");
            timerCountingUp = timerDuration; //makes it equal what it cuttently is allows it to stop
            iscountingup = false; //makes it so it can go down now
        }

        if (timerCountingUp <= 0f) //makes it so once it finshes counting down it starts to count up again
        {
            this.transform.position -= Vector3.right; //has it move left
            Debug.Log("timer has reached 0");
            timerCountingUp = 0f; //makes it so when it counts up again starts at zero 
            iscountingup = true; //makes it so it counts up again
        }


    }
}
