using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Equiqueta : MonoBehaviour
{
    public string contenidoEtiqueta = "Etiqueta";
    public int sizeFuente = 20;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TMP_Text>().text = contenidoEtiqueta;
        this.GetComponent<TMP_Text>().fontSize = sizeFuente;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
