using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{

    public Vector3 respawnPoint = new Vector3(-10.6800003f, 73.2460022f, 1.02999997f);

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = respawnPoint;

        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        collision.transform.rotation = Quaternion.identity;

        collision.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        collision.gameObject.GetComponent<Rigidbody>().inertiaTensor = Vector3.one;
    }
}
