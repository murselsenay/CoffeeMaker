using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainedBeans : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {      
    }

    public void OnCollisionStay (Collision other) {
        if (other.transform.gameObject.tag == "canDeform") {
            MeshDeformer meshDeformer = other.transform.GetComponent<MeshDeformer> ();
            ContactPoint[] contactPoints = new ContactPoint[other.contactCount];
            other.GetContacts (contactPoints);
            foreach (ContactPoint contactPoint in contactPoints) {
                meshDeformer.Deform (contactPoint.point, 0.1f, 0.05f, -0.1f, -0.05f, Vector3.up);
            }
        }
        Destroy(gameObject,1);
    }
   
}
