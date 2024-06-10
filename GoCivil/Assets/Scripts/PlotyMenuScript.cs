using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlotyMenuScript : MonoBehaviour
{
    public TextMeshProUGUI idtxt;

    private PlotResursiScript plot;

    internal void OdabraniPlot(PlotResursiScript odabrani)
    {
        this.plot = odabrani;
        String text = "";
        text = odabrani.id + "\n";
        text = odabrani.plotStanje != PlotStanje.izgradjeno ? text + odabrani.plotStanje.ToString() + "\n" : text + odabrani.NazivZgrade() + "\n";
        text = text + "\n" + odabrani.VratiResurse();
        idtxt.text = text;
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
