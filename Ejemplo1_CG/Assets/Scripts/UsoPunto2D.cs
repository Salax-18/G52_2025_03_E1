using Package2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsoPunto2D : MonoBehaviour
{
    private List<Punto2D> listaPuntos = new List<Punto2D>();
    private Vector3 ultimaPosicion;
    


    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));


        if (Vector3.Distance(mousePos, ultimaPosicion) > 50f)
        {
            ultimaPosicion = mousePos;

            Punto2D nuevoPunto = new Punto2D(worldPos.x, worldPos.y);
            listaPuntos.Add(nuevoPunto);

            Debug.Log("Punto guardado " + worldPos.x + ", " + worldPos.y);
        }
    }

    public void GuardarPuntosButton()
    {
        Utilidades.GuardarPuntosJSON(listaPuntos, "puntosRegistrados");
        Debug.Log("Puntos guardados.");
    }
}


