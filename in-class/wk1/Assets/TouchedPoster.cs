using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedPoster : MonoBehaviour
{

    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touched()
    {
        anim.Play();
        Debug.Log("Poster Touched");
    }
}
