using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredEvent : MonoBehaviour
{
    public GameObject objectToMakeAppear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makeAppear()
    {
        objectToMakeAppear.SetActive(true);
    }
}
