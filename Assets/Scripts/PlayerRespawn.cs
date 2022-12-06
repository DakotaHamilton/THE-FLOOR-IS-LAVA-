using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    public Vector3 playerReset = new Vector3(-16.4999638f, 72.75f, 1.0397718f);

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = playerReset;
    
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        collision.transform.rotation = Quaternion.identity;

        collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        collision.gameObject.GetComponent<Rigidbody>().inertiaTensor = Vector3.one;
    }
}
