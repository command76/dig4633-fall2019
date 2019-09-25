using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject FadeScreen;

    // Start is called before the first frame update
    public void FadingOut ()
    {
        FadeScreen.GetComponent<Animation>().Play("FadeAnim");
    }
}
