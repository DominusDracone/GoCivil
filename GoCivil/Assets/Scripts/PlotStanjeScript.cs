using Assets.Scripts;
using Assets.Scripts.Zgrade;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotStanjeScript : MonoBehaviour
{
    public int id;

    public List<GameObject> veze = new List<GameObject>();
    private List<VezaScript> vezeScripts = new List<VezaScript>();
    private List<AResursi> resursi = new List<AResursi>();
    private AZgrada zgrada;

    internal PlotStanjeEnum plotStanje;


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
        foreach (AResursi r in resursi)
        {
            text = text + $"\n{r}";
        }

        return text;
    }

    internal List<AZgrada> VratiZgradeZaZidanje()
    {
        List<AZgrada> zgrade = new List<AZgrada>();

        if(zgrada == null)
        {
            zgrade.Add(new Naselje1());
            zgrade.Add(new Kula());
        }
        else
        {
            zgrade = zgrada.VratiZgradeZaZidanje();
        }

        return zgrade;
    }

    internal void ZapocniIzgradnju(AZgrada z)
    {
        z.PlotId = id;
        //postavljanje temelja i skela
        //smanjivanje resursa i novac
        z.Cena(resursi);
        //dodavanje zgrade u listu zgrada za izgradnju
        GameManager.Instance.ZapocniIzgradnju(z);
    }

    internal void Izgradi(AZgrada z)
    {
        //napraviti objekat, animacija i sl.
        //promeniti stanje resursa
        z.PromeniPrirastaj(resursi);
    }
}
