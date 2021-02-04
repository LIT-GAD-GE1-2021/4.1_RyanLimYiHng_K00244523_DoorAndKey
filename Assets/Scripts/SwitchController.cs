using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public static bool keyEnable;
    private bool switchEnable;
    public DoorController doorScript;
    // Start is called before the first frame update
    void Start()
    {
        keyEnable = false;
        switchEnable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchEnable == true && keyEnable == true)
        {
            if ((Input.GetKeyDown(KeyCode.Z)) == true)
            {
                doorScript.DoorOpen();
                Debug.Log("OpenDoor");
                keyEnable = false;
            }
        }    
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        switchEnable = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        switchEnable = false;
    }
}
