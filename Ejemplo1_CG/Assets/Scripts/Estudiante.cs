using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace PackagePersona
{

    public class Estudiante : Persona
    {
        private string codeE;
        private string nameCarreraE;

        public Estudiante()
        {
        }
    
        public Estudiante(string codeE, string nameCarreraE, string nameP, string mailP, string dirP)
            : base(nameP, mailP, dirP)
        {
            this.codeE = codeE;
            this.nameCarreraE = nameCarreraE;
        }
        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }
    }
}


