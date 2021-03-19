using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VardaParadisana : MonoBehaviour
{
    //Mainīgajā saglabās tekstu, ko raksta teksta laukā
    public string vards;
    public string vecums;
    //Lauks kurā ieraksta tekstu
    public GameObject ievadesLauks;
    public GameObject ievadesLauks1;
    //Kur attēlot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiezot pogu
    public void uzglabatTekstu()
    {
        vards = ievadesLauks.GetComponent<Text>().text;
        vecums = ievadesLauks1.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Tēlu sauc "+vards+" un viņam ir "+vecums+" gadi!";
    }
}