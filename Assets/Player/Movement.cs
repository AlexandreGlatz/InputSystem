using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Vector2 horizontalInput;
    public void ReceiveInput(Vector2 HorizontalInput)
    {
        horizontalInput = HorizontalInput;
    }
}