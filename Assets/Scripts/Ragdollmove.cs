using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdollmove : MonoBehaviour
{
    public GameObject Dummy;
    Rigidbody RagDollRigidbody;
    public Vector3 ForceMagnitudeUP = new Vector3(0.0f, 5.0f, 0.0f);
    public Vector3 ForceMagnitudeDOWN = new Vector3(0.0f, -5.0f, 0.0f);
    public Vector3 ForceMagnitudeLEFT = new Vector3(5.0f, 0.0f, 0.0f);
    public Vector3 ForceMagnitudeRIGHT = new Vector3(-5.0f, 0.0f, 0.0f);
    
    // Start is called before the first frame update
    void Start()
    {
        GetRagDoll();
    }

    // Update is called once per frame
    void Update()
    {
        navigate();   
    }
    void GetRagDoll()
    {
        RagDollRigidbody = Dummy.GetComponent<Rigidbody>();
    }
    void navigate()
    {
        if(Input.GetKeyDown("space"))
        {
            RagDollRigidbody.AddForce(ForceMagnitudeUP, ForceMode.Impulse);
        }
         if(Input.GetKeyDown("s"))
        {
            RagDollRigidbody.AddForce(ForceMagnitudeDOWN, ForceMode.Impulse);
        }
         if(Input.GetKeyDown("a"))
        {
            RagDollRigidbody.AddForce(ForceMagnitudeLEFT, ForceMode.Impulse);
        }
         if(Input.GetKeyDown("d"))
        {
            RagDollRigidbody.AddForce(ForceMagnitudeRIGHT, ForceMode.Impulse);
        }
    }
}
