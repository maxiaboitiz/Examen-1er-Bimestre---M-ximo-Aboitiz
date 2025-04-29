using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kms;
    public int anioVencimiento;
    public int hc;

    // Start is called before the first frame update
    void Start()
    {
        if (patente == "")
        {
            Debug.LogError("Falta la patente");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        if (modelo < 1900 || modelo > 2025)
        {
            Debug.LogError("Modelo muy antiguo");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        if (kms < 0)
        {
            Debug.LogError("Kms mal");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        if (anioVencimiento >= 2025 || anioVencimiento <= modelo)
        {
            Debug.LogError("Año VTV mal");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        if (hc < 5)
        {
            Debug.LogError("HC bajo");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        if (hc > 100)
        {
            Debug.LogError("HC alto");
            Debug.LogError("VTV No Aprobada");
            return;
        }

        Debug.Log("VTV Aprobada");
    }

    // Update is called once per frame
    void Update()
        {

        }
    }


