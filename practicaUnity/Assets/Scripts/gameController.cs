using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class gameController : MonoBehaviour
{
    private List<GameObject> cartas;

    // Start is called before the first frame update
    void Start()
    {
            cartas = new List<GameObject>();

}

// Update is called once per frame
void Update()
    {
        
    }

    public void aniadirCarta (GameObject carta)
    {
        cartas.Add(carta);
        Debug.Log("Carta añadida");
    }
}
