using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTeste : MonoBehaviour
{
    [SerializeField] int frequencia;
    Touch[] toques;
    Touch toque;
    float tempo;
    int aux, delta;

    // Start is called before the first frame update
    void Start()
    {
        tempo = 0;
        delta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        aux = Mathf.FloorToInt(tempo);
        if (aux > delta)
        {
            delta = aux + frequencia;
            toques = Input.touches;

            foreach(Touch t in toques)
            {
                Debug.Log("ID: " + t.fingerId + " (" + t.position.x + ", " + t.position.y);
            }
        }
    }
}
