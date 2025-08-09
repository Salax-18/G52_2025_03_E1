using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using PackagePersona; 
using TMPro;

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
        listaE.Add(new Estudiante("2024_02", "Ing Sistemas", "Camilo López", "clopez@uao.edu.co", "Pasoancho"));

        MostrarEstudiante(indiceActual);

        Utilidades.GuardarEstudiantesJSON(listaE, "estudiantes");

    }
    public void MostrarEstudiante(int index)
    {
        if (index >= 0 && index < listaE.Count)
        {
            Estudiante estudiante = listaE[index];
            Codigo.text = "Codigo: " + estudiante.CodeE;
            Carrera.text = "Carrera: " + estudiante.NameCarreraE;
            Nombre.text = "Nombre: " + estudiante.NameP;
            Correo.text = "Correo: " + estudiante.MailP;
            Direccion.text = "Direccion: " + estudiante.DirP;
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

