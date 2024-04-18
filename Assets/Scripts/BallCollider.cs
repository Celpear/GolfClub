using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class BallCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        string collisionObjectName = collision.gameObject.name;
        Debug.Log("collision with: " + collisionObjectName);
        if(collisionObjectName == "waterline")
        {
            SetToStartPos();
        }
    }
    void Update()
    {
        if (this.transform.position.y <= 0)
        {
            SetToStartPos();
        }
    }



    private void SetToStartPos()
    {
        GameObject startPortal = GameObject.Find("StartPortal");
        if (startPortal != null)
        {
            this.transform.position = startPortal.transform.position;
            Rigidbody ballRigidbody = this.GetComponent<Rigidbody>();
            if(ballRigidbody != null)
            {
                ballRigidbody.velocity = Vector3.zero;
                ballRigidbody.angularVelocity = Vector3.zero;
            }
        }
    }
}
