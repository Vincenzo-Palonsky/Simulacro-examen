using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{
    public int Precio1;
    public int Precio2;
    public int Precio3;
    public int DineroDisponible;

    // Start is called before the first frame update
    void Start()
    {
        int precioTotal = Precio1 + Precio2 + Precio3;

        if (precioTotal > DineroDisponible)
        {
            Debug.Log("La suma supera el monto de dinero disponible, faltan $" + (precioTotal - DineroDisponible));
        }

        else
        {
            Debug.Log("La suma no supera el monto de dinero disponible, sobrarán $" +(DineroDisponible - precioTotal));
        }
    }
}
