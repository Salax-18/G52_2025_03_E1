using Package2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsoPunto2D : MonoBehaviour
{
    private List<Punto2D> listaPuntos = new List<Punto2D>();

    void Start()
    {
        listaPuntos.Add(new Punto2D(1.0, 2.0));
        listaPuntos.Add(new Punto2D(-4.0, 3.0));
        listaPuntos.Add(new Punto2D(-3.7, 0.5));

        double distancia = listaPuntos[0].Distancia(listaPuntos[1]);
        Debug.Log("Distancia entre los puntos X y Y: " + distancia);

        
        Utilidades.GuardarPuntosJSON(listaPuntos, "puntos2D");
    }
}

