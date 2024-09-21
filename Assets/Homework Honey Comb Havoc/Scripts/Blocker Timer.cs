using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlockerTimer : MonoBehaviour
{
    public TMP_Text uiText;
    public GameObject blocker;
    public bool blockerOn = true;
    public bool randomOdds = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blockerEnabled();
        blockertimer();
    }

    void blockertimer()
    {
        if (Input.GetKeyDown("space"))
        {
            blockerOn = false;
            Debug.Log("deactivate");

            var randomNumber = Random.Range(0, 2);
            if (randomNumber == 0)
            {
                randomOdds = false;
                Debug.Log("1");
                uiText.text = "You Rolled a: 1";
                StartCoroutine(WaitforBlocker());
            }

            else if (randomNumber == 1)
            {
                randomOdds = true;
                Debug.Log("2");
                uiText.text = "You Rolled a: 2";
                StartCoroutine(WaitforBlocker2());
            }

            
        }
    }
    
IEnumerator WaitforBlocker()
    {
        Debug.Log("wait for blocker active");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("times up");
        blockerOn = true;
    }

    IEnumerator WaitforBlocker2()
    {
        Debug.Log("wait for blocker active");
        yield return new WaitForSeconds(0.65f);
        Debug.Log("times up");
        blockerOn = true;
    }

    void blockerEnabled() 
    {
        if (blockerOn == true) 
        {
            blocker.SetActive(true);
            Debug.Log("is active");
        }
        else
        {
            blocker.SetActive(false);
            Debug.Log("is disabled");
        }
    }
}
