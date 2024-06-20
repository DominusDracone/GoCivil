using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlotMenuScript : MonoBehaviour
{
    public TextMeshProUGUI idtxt;

    private PlotStanjeScript plot;
    private List<AZgrada> zgrade;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button[] dugmici = GetComponentsInChildren<UnityEngine.UI.Button>();

        foreach (UnityEngine.UI.Button b in dugmici)
        {
            b.GetComponent<UnityEngine.UI.Image>().enabled = false;
            b.GetComponent<UnityEngine.UI.Button>().enabled = false;
            b.GetComponentInChildren<Text>().text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    internal void OdabraniPlot(PlotStanjeScript odabrani)
    {
        //ispisivanje resursa
        this.plot = odabrani;
        String text = "";
        text = odabrani.id + "\n";
        text = odabrani.plotStanje != PlotStanjeEnum.izgradjeno ? text + odabrani.plotStanje.ToString() + "\n" : text + odabrani.NazivZgrade() + "\n";
        text = text + "\n" + odabrani.VratiResurse();
        idtxt.text = text;

        //postavljanje dugmica za zidanja        
        PostaviDugmiceZaZgrade();
    }

    private void PostaviDugmiceZaZgrade()
    {
        UnityEngine.UI.Button[] dugmici = GetComponentsInChildren<UnityEngine.UI.Button>();
        zgrade = plot.VratiZgradeZaZidanje();
        int brojac = 0;
        

        foreach (AZgrada z in zgrade)
        {
            dugmici[brojac].GetComponent<UnityEngine.UI.Button>().enabled = true;
            dugmici[brojac].GetComponent<UnityEngine.UI.Image>().enabled = true;
            dugmici[brojac].GetComponentInChildren<Text>().text = z.VratiNaziv();
            brojac++;
        }
    }

    public void Deselect()
    {
        idtxt.text = "";
    }

    public void Izgradi(int br)
    {
        plot.ZapocniIzgradnju(zgrade[br]);
    }
}
