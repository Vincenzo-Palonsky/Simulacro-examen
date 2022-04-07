//1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 == Numero2)
        {
            Debug.Log("Los números son iguales.");
        }

        else
        {
            Debug.Log("Los números no son iguales.");
        }
    }
}
