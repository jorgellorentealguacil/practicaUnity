using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class gameController : MonoBehaviour
{


    private List<ImageTarget> cartas = new List<ImageTarget>();
    public GameObject prefab;
    private int pelotas;
    // Start is called before the first frame update
    void Start()
    {
        pelotas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pelotas == 0 && cartas.Count > 0)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    public void aniadirCarta(ImageTarget carta)
    {
        cartas.Add(carta);
    }


}
