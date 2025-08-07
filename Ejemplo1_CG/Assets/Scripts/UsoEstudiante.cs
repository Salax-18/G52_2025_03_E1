using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PackagePersona; 
using System.Collections.Generic;  
using TMPro; // Ensure you have TextMeshPro package installed

public class UsoEstudiante : MonoBehaviour
{
    public TextMeshProUGUI Codigo;
    public TextMeshProUGUI Carrera;
    public TextMeshProUGUI Nombre;
    public TextMeshProUGUI Correo;
    public TextMeshProUGUI Direccion;


    private List<Estudiante> listaE = new List<Estudiante>();
    private int indiceActual = 0;

    void Start()
    {
        listaE.Add(new Estudiante("2025_03", "Ing Multimedia", "David Castro", "dacastro@uao.edu.co", "Carrera 34"));
        listaE.Add(new Estudiante("2023_03", "Ing Industrial", "Maria Perez", "merez@uao.edu.co", "Calle 14"));
        listaE.Add(new Estudiante("2024_01", "Ing Sistemas", "Camilo López", "clopez@uao.edu.co", "Pasoancho"));

        MostrarEstudiante(indiceActual);
    }

    public void MostrarEstudiante(int index)
    {
        if (index >= 0 && index < listaE.Count)
        {
            Estudiante estudiante = listaE[index];
            Codigo.text = "Nombre: " + estudiante.NameP;
            Carrera.text = "Correo: " + estudiante.MailP;
            Nombre.text = "Dirección: " + estudiante.DirP;
            Correo.text = "Código: " + estudiante.CodeE;
            Direccion.text = "Carrera: " + estudiante.NameCarreraE;
        }
    }

    public void SiguienteEstudiante()
    {
        if (indiceActual < listaE.Count - 1)
        {
            indiceActual++;
            MostrarEstudiante(indiceActual);
        }
    }

    public void AnteriorEstudiante()
    {
        if (indiceActual > 0)
        {
            indiceActual--;
            MostrarEstudiante(indiceActual);
        }
    }
}

