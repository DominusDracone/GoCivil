using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotResursiScript : MonoBehaviour
{
    public int id;
    public int brLjudi;
    public int hrana;
    public int drva;
    public int gradja;
    public int energent;
    public int povBrLjudi;
    public int povHrana;
    public int povDrva;
    public int povGradja;
    public int povEnergent;

    public List<GameObject> veze = new List<GameObject>();
    private List<VezaScript> vezeScripts = new List<VezaScript>();

    internal PlotStanje plotStanje;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in veze)
        {
            vezeScripts.Add(go.GetComponent<VezaScript>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal string NazivZgrade()
    {
        return "Zgrada";
    }

    internal string VratiResurse()
    {
        string text = "";
        if (brLjudi != 0)
        {
            text = text + $"Ljudi: {brLjudi} (+{povBrLjudi})\n";
        }
        if (hrana != 0)
        {
            text = text + $"Hrana: {hrana} (+{povHrana})\n";
        }
        if (drva != 0)
        {
            text = text + $"Drva: {drva} (+{povDrva})\n";
        }
        if (gradja != 0)
        {
            text = text + $"Gradja: {gradja} (+{povGradja})\n";
        }
        if (energent != 0)
        {
            text = text + $"Energent: {energent} (+{povEnergent})\n";
        }

        return text;
    }
}
