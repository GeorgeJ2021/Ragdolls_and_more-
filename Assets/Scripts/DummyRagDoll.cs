using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyRagDoll : MonoBehaviour
{
    public Collider mainCollider;
    public GameObject Dummy;
    public Animator Dummyanimator;
    public bool RagDollMode = false;

    Collider[] RagDollColliders;
    Rigidbody[] RagDollRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        GetRagDoll();
        RagDollOff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ouch")
        {
            RagDollOn();
        }
        
    }

    void GetRagDoll()
    {
        RagDollColliders = Dummy.GetComponentsInChildren<Collider>();
        RagDollRigidbody = Dummy.GetComponentsInChildren<Rigidbody>();

    }

    void RagDollOn()
    {
        foreach(Collider col in RagDollColliders)
        {
            col.enabled = true;
        }
        foreach(Rigidbody rig in RagDollRigidbody)
        {
            rig.isKinematic = false;
        }

        Dummyanimator.enabled = false;
        mainCollider.enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void RagDollOff()
    {
        foreach(Collider col in RagDollColliders)
        {
            col.enabled = false;
        }
        foreach(Rigidbody rig in RagDollRigidbody)
        {
            rig.isKinematic = true;
        }

        Dummyanimator.enabled = true;
        mainCollider.enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;

    }
}
