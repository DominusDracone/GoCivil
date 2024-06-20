using Assets.Scripts;
using Assets.Scripts.Resursi;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {  get; private set; }
    private List<AZgrada> zgrade = new List<AZgrada>();
    private List<PlotStanjeScript> plots = new List<PlotStanjeScript>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Plot"))
        {
            plots.Add(go.GetComponent<PlotStanjeScript>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SledeciPotez()
    {
        //povecvanje resursa
        //prehrana grada
        //izgradnja
        foreach (AZgrada z in zgrade)
        {
            z.PreostaloVreme--;
            if(z.PreostaloVreme == 0)
            {
                plots[z.PlotId].Izgradi(z);
            }
        }

        for (int i = zgrade.Count-1; i >= 0; i--)
        {
            if (zgrade[i].PreostaloVreme == 0)
            {
                zgrade.RemoveAt(i);
            }
        }
    }

    internal void ZapocniIzgradnju(AZgrada aZgrada)
    {
        AZgrada zgrada = aZgrada;
        zgrada.PreostaloVreme = aZgrada.VremeZidanja;
        zgrade.Add(zgrada);
    }
}
