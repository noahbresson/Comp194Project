using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandGrab : MonoBehaviour
{
    public GameObject collidingObject;
    public GameObject objectInHand;

    // Called automatically by unity when the object this script is attached to (which contains a collider) intersects an object with a rigidbody.
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Rigidbody>()) {
            collidingObject = other.gameObject;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        collidingObject = null;
    }

    void Update ()
    {
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") > 0.2f && collidingObject) 
        {
            GrabObject();
        }

        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") < 0.2f && objectInHand) 
        {
            ReleaseObject();
        }
    }

    public void GrabObject()
    {
        objectInHand = collidingObject;
        objectInHand.transform.SetParent (this.transform);
        objectInHand.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void ReleaseObject()
    {
        objectInHand.GetComponent<Rigidbody>().isKinematic = false;
        objectInHand.transform.SetParent (null);
        objectInHand = null;
    }
}

