using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void update()
    {
        transform.position = cameraPosition.position;
    }
}
