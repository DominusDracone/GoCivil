using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VezaScript : MonoBehaviour
{
    public List<GameObject> plots = new List<GameObject>();
    private List<PlotResursiScript> plotsScripts = new List<PlotResursiScript>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in plots)
        {
            plotsScripts.Add(go.GetComponent<PlotResursiScript>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
