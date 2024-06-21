using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPrimeShield : MonoBehaviour
{

    [SerializeField] GameObject Crewmate;

    [SerializeField] AudioSource AudioTache;
    [SerializeField] AudioClip Shield;
    [SerializeField] AudioClip TacheFini;


    [SerializeField] GameObject FondTache;
    [SerializeField] GameObject BoutonQuitterTache;
    [SerializeField] GameObject Bloc1;
    [SerializeField] GameObject Bloc2;
    [SerializeField] GameObject Bloc3;
    [SerializeField] GameObject Bloc4;
    [SerializeField] GameObject Bloc5;
    [SerializeField] GameObject Bloc6;
    [SerializeField] GameObject Bloc7;
    [SerializeField] GameObject Bloc8;
    [SerializeField] GameObject Bloc9;

    [SerializeField] Color CouleurRouge;
    [SerializeField] Color CouleurVert;


    [SerializeField] Image Bloc1Image;
    [SerializeField] Image Bloc2Image;
    [SerializeField] Image Bloc3Image;
    [SerializeField] Image Bloc4Image;
    [SerializeField] Image Bloc5Image;
    [SerializeField] Image Bloc6Image;
    [SerializeField] Image Bloc7Image;
    [SerializeField] Image Bloc8Image;
    [SerializeField] Image Bloc9Image;


    private bool bloc1Actif = false;
    private bool bloc2Actif = false;
    private bool bloc3Actif = false;
    private bool bloc4Actif = false;
    private bool bloc5Actif = false;
    private bool bloc6Actif = false;
    private bool bloc7Actif = false;
    private bool bloc8Actif = false;
    private bool bloc9Actif = false;
    private bool MusicFin = false;
    private bool FinTache = false;



    // Start is called before the first frame update
    void Start()
    {
        RandomBool();
    }

    // Update is called once per frame
    void Update()
    {
        ValidationBloc();
    }

    public bool FinTacheReturn()
    {
        return FinTache;
    }

    public void PlaySoundSHield()
    {
        AudioTache.PlayOneShot(Shield);
    }
    public void PlayFinTache()
    {
        if(MusicFin == false)
        {
            MusicFin = true;
            FinTache = true;
            AudioTache.PlayOneShot(TacheFini);
            Debug.Log(FinTache);
        }
        
    }


    public void ValiderClick1()
    {
        bloc1Actif = true;
    }

    public void ValiderClick2()
    {
        bloc2Actif = true;
    }

    public void ValiderClick3()
    {
        bloc3Actif = true;
    }

    public void ValiderClick4()
    {
        bloc4Actif = true;
    }

    public void ValiderClick5()
    {
        bloc5Actif = true;
    }

    public void ValiderClick6()
    {
        bloc6Actif = true;
    }

    public void ValiderClick7()
    {
        bloc7Actif = true;
    }

    public void ValiderClick8()
    {
        bloc8Actif = true;
    }

    public void ValiderClick9()
    {
        bloc9Actif = true;
    }








    public void OuvrirPrimeShield()
    {
        if (Crewmate.GetComponent<PlayerCrewmate>().ReturnPrimeShield() == true && Crewmate.GetComponent<PlayerCrewmate>().ReturnUtiliser() == true)
        {
            FondTache.SetActive(true); 
            BoutonQuitterTache.SetActive(true);
            Bloc1.SetActive(true);
            Bloc2.SetActive(true);
            Bloc3.SetActive(true);
            Bloc4.SetActive(true);
            Bloc5.SetActive(true);
            Bloc6.SetActive(true);
            Bloc7.SetActive(true);
            Bloc8.SetActive(true);
            Bloc9.SetActive(true);
        }
    }

    public void ValidationBloc()
    {
        if (bloc1Actif == true)
        {
            Bloc1Image.color = CouleurVert;
        }

        if (bloc2Actif == true)
        {
            Bloc2Image.color = CouleurVert;
        }

        if (bloc3Actif == true)
        {
            Bloc3Image.color = CouleurVert;
        }

        if (bloc4Actif == true)
        {
            Bloc4Image.color = CouleurVert;
        }

        if (bloc5Actif == true)
        {
            Bloc5Image.color = CouleurVert;
        }

        if (bloc6Actif == true)
        {
            Bloc6Image.color = CouleurVert;
        }

        if (bloc7Actif == true)
        {
            Bloc7Image.color = CouleurVert;
        }

        if (bloc8Actif == true)
        {
            Bloc8Image.color = CouleurVert;
        }

        if (bloc9Actif == true)
        {
            Bloc9Image.color = CouleurVert;
        }

        if (bloc9Actif == true && bloc8Actif == true && bloc7Actif == true && bloc6Actif == true && bloc5Actif == true && bloc4Actif == true && bloc3Actif == true && bloc2Actif == true  && bloc1Actif == true)
        {
            FondTache.SetActive(false);
            BoutonQuitterTache.SetActive(false);
            Bloc1.SetActive(false);
            Bloc2.SetActive(false);
            Bloc3.SetActive(false);
            Bloc4.SetActive(false);
            Bloc5.SetActive(false);
            Bloc6.SetActive(false);
            Bloc7.SetActive(false);
            Bloc8.SetActive(false);
            Bloc9.SetActive(false);
            
            Debug.Log("J'ai fini ma tache PrimeShield");
            PlayFinTache();


        }

    }

    public void FermerPrimeShield()
    {
        FondTache.SetActive(false);
        BoutonQuitterTache.SetActive(false);
        Bloc1.SetActive(false);
        Bloc2.SetActive(false);
        Bloc3.SetActive(false);
        Bloc4.SetActive(false);
        Bloc5.SetActive(false);
        Bloc6.SetActive(false);
        Bloc7.SetActive(false);
        Bloc8.SetActive(false);
        Bloc9.SetActive(false);
    }



    public void RandomBool()
    {
        if (Random.Range(0, 2) == 1)
        {
            /*Bloc3.SetActive(true);
            Bloc4.SetActive(true);
            Bloc5.SetActive(true);
            Bloc6.SetActive(true);*/
            bloc3Actif = true;
            bloc4Actif = true;
            bloc5Actif = true;
            bloc6Actif = true;
        }
        else if (Random.Range(0, 2) == 0)
        {
            /*Bloc6.SetActive(true);
            Bloc7.SetActive(true);
            Bloc8.SetActive(true);
            Bloc9.SetActive(true);*/
            bloc6Actif = true;
            bloc7Actif = true;
            bloc8Actif = true;
            bloc9Actif = true;
        }
        else if (Random.Range(0, 2) == 2)
        {

            /*Bloc4.SetActive(true);
            Bloc5.SetActive(true);
            Bloc8.SetActive(true);
            Bloc9.SetActive(true);*/
            bloc4Actif = true;
            bloc5Actif = true;
            bloc8Actif = true;
            bloc9Actif = true;

        }


    }

}
