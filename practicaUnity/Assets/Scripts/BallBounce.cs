using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0.2f, 0f), ForceMode.Impulse);

    }
}
