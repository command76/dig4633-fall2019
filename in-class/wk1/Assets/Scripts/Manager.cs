using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public bool gRed;
    public bool gBlack;
    public static int counter;
    public static bool winState = false;
    public GameObject Fade;

    public void SetCondition()
    {
            if (gBlack == true)
        {
            counter++;
            Debug.Log("GBlack " + counter);
        }

        if (gRed == true)
        {
            counter++;
            Debug.Log("GRED " + counter);
        }
        //myValue = myValue + 1;
        //Debug.Log(myValue);
        if (counter == 2)
        {
            winState = true;
            Debug.Log("winState: " + winState);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(this.gameObject.name);
        //Debug.Log(AddFunction(myValue));
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.winState)
        {
            Fade.SetActive(true);
                //Debug.Log("winState");
        }
    }
}
