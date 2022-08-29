using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Vector3 impulseMagnitude = new Vector3(5.0f, 0.0f, 0.0f);
    bool oof = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void  Update()
    {
        if(oof == false)
        {
            GetComponent<Rigidbody>().AddForce(impulseMagnitude, ForceMode.Impulse);
        }
         
    }
     private void OnCollisionEnter(Collision collision)
    {
        oof = true;        
    }
}
