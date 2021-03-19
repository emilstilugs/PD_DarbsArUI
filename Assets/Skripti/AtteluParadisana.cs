using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject cimdi;
    public GameObject cimdi1;
    public GameObject cimdi2;
    public GameObject tkrekls;
    public GameObject tkrekls1;
    public GameObject tkrekls2;
    public GameObject dzemperis;
    public GameObject dzemperis1;
    public GameObject bikses;
    public GameObject bikses1;
    public GameObject sorti;
    public GameObject sorti1;
    public GameObject kurpes;
    public GameObject kurpes1;
    public GameObject kurpes2;
    public GameObject kurpes3;
    public GameObject kurpes4;
    public GameObject kurpes5;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slider;
    public GameObject slider1;
    public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;
    public void TkrekliAttelosana(bool vertiba)
    {
        tkrekls.SetActive(vertiba);
        tkrekls1.SetActive(vertiba);
        tkrekls2.SetActive(vertiba);
    }
    public void CimdiAttelosana(bool vertiba)
    {
        cimdi.SetActive(vertiba);
        cimdi1.SetActive(vertiba);
        cimdi2.SetActive(vertiba);
    }
    public void DzemperisAttelosana(bool vertiba)
    {
        dzemperis.SetActive(vertiba);
        dzemperis1.SetActive(vertiba);
    }
    public void BiksesAttelosana(bool vertiba)
    {
        bikses.SetActive(vertiba);
        bikses1.SetActive(vertiba);
    }
    public void SortiAttelosana(bool vertiba)
    {
        sorti.SetActive(vertiba);
        sorti1.SetActive(vertiba);
    }
    public void KurpesAttelosana(bool vertiba)
    {
        kurpes.SetActive(vertiba);
        kurpes1.SetActive(vertiba);
        kurpes2.SetActive(vertiba);
        kurpes3.SetActive(vertiba);
        kurpes4.SetActive(vertiba);
        kurpes5.SetActive(vertiba);
    }

    public void dropdown(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }

    public void mainitLielumu()
    {
        float pasreizejaVertiba = slider.GetComponent<Slider>().value;
        float pasreizejaVertiba1 = slider1.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        cimdi.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        cimdi.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        cimdi1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        cimdi1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        cimdi2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        cimdi2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        tkrekls.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        tkrekls.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        tkrekls1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        tkrekls1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        tkrekls2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        tkrekls2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        dzemperis.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        dzemperis.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        dzemperis1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        dzemperis1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        bikses.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        bikses.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        bikses1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        bikses1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        sorti.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        sorti.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        sorti1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        sorti1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes1.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes2.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes3.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes3.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes4.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes4.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);

        kurpes5.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
        kurpes5.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba1);
    }

    public void uzbiditsUzAttela()
    {
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNobiditsNoAttela()
    {
        skanasAvots.Stop();
    }
}
