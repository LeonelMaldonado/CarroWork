using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{


    [SerializeField] public string Nombre;
    [SerializeField] public float Velocidad;
    [SerializeField] public int CapacidadDeCombustible;
    [SerializeField] public int CombustibleActual;

    public virtual void Acelerar()
    {
        Debug.Log(Nombre + " esta acelerando a" + Velocidad + " 358Km/h");
    }

    public void Frenar()
    {
        Debug.Log(Nombre + " esta frenando");
    }

    public void Tanquear(int Cantidad)
    {
        CombustibleActual += Cantidad;

        if (CombustibleActual > CapacidadDeCombustible)
        {
            CombustibleActual = CapacidadDeCombustible;
        }
        Debug.Log(Nombre + " a tanqueado.CombustibleActual " + CombustibleActual);
    }

}
