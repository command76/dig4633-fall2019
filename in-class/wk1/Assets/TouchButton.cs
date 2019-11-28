using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TouchButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static int[] buttons = new int[1];
    private static int[] correctCombo = { 1, 1, 1, 1, 1, 1 };
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;



    // Update is called once per frame
    void Update()
    {

    }
    //Use Interactable Asset from VRTK Game Assets > Prefab > Interations > Interactables > Interactable.Primary_Grap.Secondard_None(Prefab Asset)
    //Assign interactable asset as collision handler for Collision Started event data
    //Array.Empty() could be useful

    public void ButtonTouched(string buttonPressed)

    {
        if (buttons.Length < 7)
        {
            if (buttons[0] == 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 1;
                    Debug.Log(buttonPressed);
                    //button1.GetComponentInChildren<MeshRenderer>(false);
                    Debug.Log("buttons[0]:" + buttons[0]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 2;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 3;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[0] = 4;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 5;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 6;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 7;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[0] = 8;
                    Debug.Log("buttons[0]:" + buttons[0]);
                }
            }
            else if (buttons[1] == 0 && buttons[0] != 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 1;
                    Debug.Log("buttons[1]:" + buttons[1]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 2;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 3;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[1] = 4;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 5;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 6;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 7;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[1] = 8;
                    Debug.Log("buttons[1]:" + buttons[1]);
                }
            }
            else if (buttons[2] == 0 && buttons[1] != 0 && buttons[0] != 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 1;
                    Debug.Log("buttons[2]:" + buttons[2]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 2;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 3;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[2] = 4;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 5;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 6;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 7;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[2] = 8;
                    Debug.Log("buttons[2]:" + buttons[2]);
                }

            }
            else if (buttons[3] == 0 && buttons[2] != 0 && buttons[1] != 0 && buttons[0] != 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 1;
                    Debug.Log("buttons[3]:" + buttons[3]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 2;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 3;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[3] = 4;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 5;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 6;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 7;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[3] = 8;
                    Debug.Log("buttons[3]:" + buttons[3]);
                }
            }
            else if (buttons[4] == 0 && buttons[3] != 0 && buttons[2] != 0 && buttons[1] != 0 && buttons[0] != 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 1;
                    Debug.Log("buttons[4]:" + buttons[4]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 2;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 3;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[4] = 4;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 5;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 6;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 7;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[4] = 8;
                    Debug.Log("buttons[4]:" + buttons[4]);
                }
            }
            else if (buttons[5] == 0 && buttons[4] != 0 && buttons[3] != 0 && buttons[2] != 0 && buttons[1] != 0 && buttons[0] != 0)
            {
                if (button1 == isActiveAndEnabled && buttonPressed == "button1")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 1;
                    Debug.Log("buttons[5]:" + buttons[5]);
                    //Debug.Log("button1");
                }
                else if (button2 == isActiveAndEnabled && buttonPressed == "button2")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 2;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button3 == isActiveAndEnabled && buttonPressed == "button3")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 3;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button4 == isActiveAndEnabled && buttonPressed == "button4")
                {
                    buttons[5] = 4;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button5 == isActiveAndEnabled && buttonPressed == "button5")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 5;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button6 == isActiveAndEnabled && buttonPressed == "button6")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 6;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button7 == isActiveAndEnabled && buttonPressed == "button7")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 7;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
                else if (button8 == isActiveAndEnabled && buttonPressed == "button8")
                {
                    Array.Resize(ref buttons, buttons.Length + 1);
                    buttons[5] = 8;
                    Debug.Log("buttons[5]:" + buttons[5]);
                }
            }
        }
        else if ((buttons[0] == correctCombo[0]) && (buttons[1] == correctCombo[1])
           && (buttons[2] == correctCombo[2]) && (buttons[3] == correctCombo[3])
           && (buttons[4] == correctCombo[4]) && (buttons[5] == correctCombo[5]))
        {
            Debug.Log("You did it!");
        }
        else
        {
            buttons = Array.Empty<int>();
            Array.Resize(ref buttons, buttons.Length + 1);
            Debug.Log(buttons[0]);
        }


    }



}























    //public void Button1Touched()
    //{
    //    buttons[0] = 1;
    //    Debug.Log(buttons[0]);

    //}
    //public void Button2Touched()
    //{
    //    buttons[1] = 2;
    //    Debug.Log(buttons[1]);

    //}
    //public void Button3Touched()
    //{
    //    buttons[2] = 3;
    //    Debug.Log(buttons[2]);

    //}
    //public void Button4Touched()
    //{
    //    buttons[3] = 4;
    //    Debug.Log(buttons[3]);

    //}
    //public void Button5Touched()
    //{
    //    buttons[4] = 5;
    //    Debug.Log(buttons[4]);

    //}
    //public void Button6Touched()
    //{
    //    buttons[5] = 6;
    //    Debug.Log(buttons[5]);

    //}


//}
