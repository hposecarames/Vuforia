using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pulsaciones : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro textMesh;
    public string texto;
    void Start()
    {
        te = GetComponent<TextMeshPro>();
        texto = "Prueba";
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches){
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube")
                {
                    texto = "Vale Jonathan";

                }
            }
        }
    }
}
