using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{
    void Example()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
}