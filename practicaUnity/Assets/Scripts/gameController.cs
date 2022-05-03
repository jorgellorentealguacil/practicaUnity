using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class gameController : MonoBehaviour
{
    //Variables privadas para manejar 
    private List<GameObject> cartas;
    private int contP;
    private GameObject pelota;

    //Variables públicas para gestionar por Unity Editor
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
            cartas = new List<GameObject>();
        contP = 0;

    }

   // Update is called once per frame
    void Update()
    {
        if(contP == 0 && cartas.Count > 0)
        {
            pelota = Instantiate(prefab, transform.position, transform.rotation);
            contP = 1;
        }
        else if (contP == 1 && cartas.Count == 0)
        {
            contP = 0;
            DestroyImmediate(pelota, true);
        }
        
    }

    public void aniadirCarta(GameObject carta)
    {
        cartas.Add(carta);
        Debug.Log("Carta añadida");
    }

    public void eliminarCarta (GameObject carta)
    {
        if(cartas.Contains(carta))
        {
            cartas.Remove(carta);
            Debug.Log("Carta eliminada");
        }
        
    }
}
