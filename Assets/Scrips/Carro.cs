using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : Vehiculo
{
    public int NumeroDePuertas;

    public override void Acelerar()
    {
        Debug.Log(Nombre + " esta acelerando a" + Velocidad + " 358Km/h");
    }

}
