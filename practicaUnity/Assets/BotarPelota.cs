using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotarPelota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 2f, 0f), ForceMode.Impulse);

    }
}
