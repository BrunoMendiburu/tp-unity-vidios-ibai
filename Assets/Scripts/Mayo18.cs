﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mayo18 : MonoBehaviour
{
    public int edadUsuario = 0;
    public Text miTexto; 

    void Start()
    {

        if (edadUsuario >= 18)
        {
            miTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }

        else {
            miTexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad"); 
        }
        
    }

   
}
