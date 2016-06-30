using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    int cnt = 1;
    float start;
    bool shouldPrintOver20 = true;
    bool shouldPrintOver30 = true;
    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        start = transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        float distance = transform.position.z - start;
        if(distance > 30)
        {
            if (shouldPrintOver30)
            {
                Debug.Log("Over 30 : " + distance);
                shouldPrintOver30 = false;
            }
        }
        else if (distance > 20)
        {
            if (shouldPrintOver20)
            {
                Debug.Log("Over 20 : " + distance);
                shouldPrintOver20 = false;
            }          
        }
	}

    void TestMethod()
    {
        Debug.Log("Test");
    }
}

