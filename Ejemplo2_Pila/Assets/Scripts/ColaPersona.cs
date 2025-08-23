using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ColaPersona : MonoBehaviour
{
   
    public TMP_InputField NombrePersona;
    public TMP_InputField CorreoPersona;
    public TMP_InputField EdadPersona;

    
    public TMP_Text textoMensaje;
    public TMP_Text ElementosCola;

    // Cola de personas 
    private Queue<string> colaDatos = new Queue<string>();

   
    public void Encolar()
    {
        string nombre = NombrePersona.text.Trim();
        string correo = CorreoPersona.text.Trim();
        string edad = EdadPersona.text.Trim();

       
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(edad))
        {
            textoMensaje.text = "Por favor, completa todos los campos.";
            return;
        }

       
        if (!int.TryParse(edad, out int edadNumerica))
        {
            textoMensaje.text = " La edad debe ser un número.";
            return;
        }

      
        string persona = $"Nombre: {nombre} | Correo: {correo} | Edad: {edadNumerica}";
        colaDatos.Enqueue(persona);

        textoMensaje.text = "Persona encolada.";
        ActualizarElementosCola();

        
        NombrePersona.text = "";
        CorreoPersona.text = "";
        EdadPersona.text = "";
    }

    // Método  desencolar 
    public void Desencolar()
    {
        if (colaDatos.Count > 0)
        {
            string persona = colaDatos.Dequeue();
            textoMensaje.text = $"Persona desencolada:\n{persona}";
            ActualizarElementosCola();
        }
        else
        {
            textoMensaje.text = " La cola está vacía.";
        }
    }

   
    public void Peek()
    {
        if (colaDatos.Count > 0)
        {
            string persona = colaDatos.Peek();
            textoMensaje.text = $" Primera en la cola:\n{persona}";
        }
        else
        {
            textoMensaje.text = " La cola está vacía.";
        }
    }

    
    public void VaciarCola()
    {
        colaDatos.Clear();
        textoMensaje.text = " Cola vaciada.";
        ActualizarElementosCola();
    }

    
    private void ActualizarElementosCola()
    {
        ElementosCola.text = "";

        if (colaDatos.Count == 0)
        {
            ElementosCola.text = " Cola vacía.";
            return;
        }

        foreach (string persona in colaDatos)
        {
            ElementosCola.text += persona + "\n";
        }
    }
}



