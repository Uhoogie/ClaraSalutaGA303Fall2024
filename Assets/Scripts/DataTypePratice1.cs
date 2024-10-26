using System.Collections;
using System.Collections.Generic;
using UnityEngine; //alows us to use unity functions

public class NewBehaviourScript : MonoBehaviour //class declarion defines the class we are using
{


    //Whole Number//

    public int num1;//int is 4 bytes - stores full numbers
    public int num2; //public or private, data type, then name

    public long num3; //long is 8 bytes - stores whole number that are bigger than in

    public uint num4; //only positive number double the numbers and still 4 bytes
    public ulong num5; //^^^

    //Decimals//

    public float num6 = 3.14f; //float store decimal numbers up to 4 digits - 4 bytes - can assign numbers giving more precision - put f at end
    public double num7 = 3.14; //double the float used for physics simulations typically - 8 bytes - doesn't need f at end

    //True or False//

    public bool isProgrammingHard = true; //can onlybe 0 or 1, 1 = true, 0 = false

  
    //THESE ARE DATATYPES? NEXT TIME
    //public Light light;
    //public Transform transform;

    //DATA SIZES
    //1 byte = 8 bits
    //1024 bytes = 1 kilobyte
    //1024 kilobyte = 1 megabytes
    //1024 megabytes = 1 terabytes

    //300Mbps - This is not 300 MBps - this is 300 Megabits per second
    //1 gigabit internet = download speed of 125 MegaBYTES per second max

    // TEXT Var

    public char chara = 'a'; //holds 1 character
    public string frisk = "I can write" +
        " anything L bozo"; //this can be mutliple charaters, if I hit enter it will do the + junk




    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("The starting number for num1 is:" + num1);
        num1 = num1 + 1;
        Debug.Log("The number number for num 1 after adding 1 is:" + num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
