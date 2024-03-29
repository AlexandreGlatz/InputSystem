using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public MyInputSystem InputSystem;
    public Rigidbody playerBody;
    public void MoveForward()
    {
        Vector3 currentVelocity = new Vector3(0, 0,playerBody.velocity.z);
        currentVelocity += new Vector3(0, 0, 1);
        playerBody.velocity = currentVelocity;
    }

    // Start is called before the first frame update
    void Start()
    {
        InputSystem.CreateAction("Forward", MoveForward, KeyCode.Z);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<InputSystem.actionAmount; i++)
        {
            if(Input.GetKeyDown(InputSystem.actions[i].keyCode))
                InputSystem.ExecuteAction(i);
        }
        Input.GetKeyDown(KeyCode.Escape);
    }
}
