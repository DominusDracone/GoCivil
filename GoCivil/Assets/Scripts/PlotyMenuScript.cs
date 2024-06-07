using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlotyMenuScript : MonoBehaviour
{
    public TextMeshProUGUI idtxt;

    private ClicablePlotScript plot;

    internal void OdabraniPlot(ClicablePlotScript odabrani)
    {
        this.plot = odabrani;
        idtxt.text = plot.id.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
