using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;


public class PilaImagenes : MonoBehaviour
{
    public Transform panelImagenes;
    public GameObject imagenPrefab;
    public TMP_Text PilaText;

    private Stack<GameObject> pilaImagenes = new Stack<GameObject>();

    public void PushImagen()
    {
        GameObject nuevaImagen = Instantiate(imagenPrefab, panelImagenes);
        pilaImagenes.Push(nuevaImagen);

        PilaText.text = "Imagenes en la pila: " + pilaImagenes.Count;
    }

    public void PopImagen()
    {
        if (pilaImagenes.Count > 0)
        {
            GameObject imagenTope = pilaImagenes.Pop();
            Destroy(imagenTope);
            PilaText.text = "Imagenes en la pila: " + pilaImagenes.Count;

        }
        else
        {
            Debug.Log("La pila está vacía");
        }
    }
        public void PeekImagen()
    {
        if (pilaImagenes.Count > 0)
        {
            GameObject imagenTope = pilaImagenes.Peek();
            
            Image img = imagenTope.GetComponent<Image>();
            if (img != null)
            {
                img.color = Color.yellow;
                Invoke("RestaurarColorTope", 1f); 
            }
        }
    }


    private void RestaurarColorTope()
    {
        if (pilaImagenes.Count > 0)
        {
            GameObject imagenTope = pilaImagenes.Peek();
            Image img = imagenTope.GetComponent<Image>();
            if (img != null)
            {
                img.color = Color.white;
            }
        }
    }

    public void ClearPila()
    {
        while (pilaImagenes.Count > 0)
        {
            GameObject imagen = pilaImagenes.Pop();
            Destroy(imagen);
        }
        PilaText.text = "Pila vacía";
    }
}








