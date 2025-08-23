using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PackagePersona;
using Package2D;
using System.IO;

public class Utilidades: MonoBehaviour
{
    public static void GuardarEstudiantesJSON(List<Estudiante> listaEstudiantes, string nombreArch)
    {
        string ruta = Path.Combine(Application.streamingAssetsPath, nombreArch + ".json");

        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }



        string json = JsonUtility.ToJson(new ListaEstudiantesWrapper { estudiantes = listaEstudiantes }, true);

        File.WriteAllText(ruta, json);
        Debug.Log("Estudiantes guardados en: " + ruta);
    }

    public static void GuardarPuntosJSON(List<Punto2D> listaPuntos, string nombreArch)
    {
        string ruta = Path.Combine(Application.streamingAssetsPath, nombreArch + ".json");

        
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }


        string json = JsonUtility.ToJson(new ListaPuntosWrapper { puntos = listaPuntos }, true);

        File.WriteAllText(ruta, json);
        Debug.Log("Puntos guardados en: " + ruta);
    }

    // Wrappers 
    [System.Serializable]
    private class ListaEstudiantesWrapper
    {
        public List<Estudiante> estudiantes;
    }

    [System.Serializable]
    private class ListaPuntosWrapper
    {
        public List<Punto2D> puntos;
    }

}
