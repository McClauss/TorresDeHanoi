using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA : MonoBehaviour
{

    //Tipos de TDAs
    public List<GameObject> myObjects;//TDA tipo Lista de Objetos
    public GameObject[] array;//TDA tipo array. No es dinámico
    public Queue<GameObject> cola; //TDA tipo cola. Primero que entra primero que sale FIFO
    public Stack<GameObject> pila; //TDA tipo cola. Última que entra primera que sale LIFO
    public Dictionary<int,string> apellidos;//Diccionario Por wejemplo para manejo de Numero de Documento y Apellidos
    public Dictionary<int,string> nombre;//Siempre toma dos datos. La llave y el Dato
    public Dictionary<int,string> mail;//Siempre toma dos datos. La llave y el Dato

    public GameObject objet;

    void Start()
    {
        //myObjects.Add(objet);//añade objeto a la liosta que definí
        if(myObjects.Contains(objet))print("Lo tengo" + objet);//Si mi lista conteiene X objetop haga algo. Ejemplo: Si personaje tiene la llave abra la puerta
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
