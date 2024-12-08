using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ControladorVehiculos : MonoBehaviour
{
    public Carro carro;
    public Moto moto;
    public Camion camion;

    private Vehiculo vehiculoActual;

    public TextMeshProUGUI infoVehiculoText;

    void Start()
    {
        carro = new Carro { Nombre = "Carro Deportivo", Velocidad = 200, CapacidadDeCombustible = 50, CombustibleActual = 20, NumeroDePuertas = 2 };
        moto = new Moto { Nombre = "Moto de Carreras", Velocidad = 180, CapacidadDeCombustible = 20, CombustibleActual = 10, TipoManillar = "Deportivo" };
        camion = new Camion { Nombre = "Camion de Carga", Velocidad = 100, CapacidadDeCombustible = 150, CombustibleActual = 80, CapacidadDeCarga = 1000, cargaActual = 500 };

        SeleccionarVehiculo(carro);  // Seleccionar coche por defecto al iniciar
    }

    public void SeleccionarVehiculo(Vehiculo vehiculo)
    {
        vehiculoActual = vehiculo;
        ActualizarInformacionVehiculo();
    }

    public void Acelerar()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Acelerar();
            ActualizarInformacionVehiculo();
        }
    }

    public void Frenar()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Frenar();
        }
    }

    public void Tanquear()
    {
        if (vehiculoActual != null)
        {
            vehiculoActual.Tanquear(10);  // Repostar una cantidad fija de 10
            ActualizarInformacionVehiculo();
        }
    }

    private void ActualizarInformacionVehiculo()
    {
        infoVehiculoText.text = $"Nombre: {vehiculoActual.Nombre}\n" +
                                $"Velocidad: {vehiculoActual.Velocidad}\n" +
                                $"Combustible: {vehiculoActual.CombustibleActual}/{vehiculoActual.CapacidadDeCombustible}";
    }
}
