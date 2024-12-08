using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVehiculos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Carro carro = new Carro { Nombre = "Coche Deportivo", Velocidad = 200, CapacidadDeCombustible = 50, CombustibleActual = 20, NumeroDePuertas = 2 };
        carro.Acelerar();
        carro.Frenar();
        carro.Tanquear(10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
