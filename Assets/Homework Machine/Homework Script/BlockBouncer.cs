using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBouncer : MonoBehaviour
{
    // Start is called before the first frame update
   public float timerCountingUp = 0f; //current time
    public float timerDuration = 1f; //time we need to wait before timer finishes
    public bool iscountingup = true; //determines if it should be going up or down

    public float tens = 10f;
    public GameObject HarpoonSpear;

      public void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(transform.up * tens);
        Debug.Log("Last chance now...");
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
            this.transform.position += Vector3.up * tens; //transforms it so it goes right when time is reached
            //Debug.Log("Up");
            timerCountingUp = timerDuration; //makes it equal what it cuttently is allows it to stop
            iscountingup = false; //makes it so it can go down now
        }

        if (timerCountingUp <= 0f) //makes it so once it finshes counting down it starts to count up again
        {
            this.transform.position -= Vector3.up * tens; //has it move left
            //Debug.Log("Down");
            timerCountingUp = 0f; //makes it so when it counts up again starts at zero 
            iscountingup = true; //makes it so it counts up again
            
        }


    }
}
