using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class UIManager : MonoBehaviour
{


    [SerializeField] GameObject SonSabotage;
    [SerializeField] GameObject RougeSabotage;


    [SerializeField] GameObject EnsembleReportIntrface;
    [SerializeField] GameObject Cadavre;
    [SerializeField] AudioSource LesSons;
    [SerializeField] AudioClip EmergencySound;
    [SerializeField] AudioClip NextVent;
    [SerializeField] AudioClip ReportBodySound;



    [SerializeField] NavMeshSurface MapIA;

    [SerializeField] GameObject Joueur01;
    [SerializeField] GameObject Joueur02;
    [SerializeField] GameObject Joueur03;
    [SerializeField] GameObject Joueur04;
    [SerializeField] GameObject Joueur05;
    [SerializeField] GameObject Joueur06;
    [SerializeField] GameObject Joueur07;
    [SerializeField] GameObject Joueur08;
    [SerializeField] GameObject Joueur09;
    [SerializeField] GameObject Joueur10;
    [SerializeField] GameObject ApreVoteBlocage;
    [SerializeField] TextMeshProUGUI TempsVote;

    private float TempsAvantFinVote = 5f;
    private float TempsAvantFinInterfaceReport = 15f;
    private bool Decompte = false;
    private bool DecompteNoVote = false;


    [SerializeField] GameObject VictorySound;
    [SerializeField] GameObject VictorySoundImpostor;
    [SerializeField] GameObject VictoryImpostor;
    [SerializeField] GameObject VictoryCrewmate;



    [SerializeField] GameObject Joueur01BoutonVote;
    [SerializeField] GameObject Joueur01BoutonConfirmation;
    [SerializeField] GameObject Joueur01BoutonNonConfirmation;
    [SerializeField] GameObject Joueur01BoutonAVoter;
    private bool Joueur01Voter;

    [SerializeField] GameObject Joueur02BoutonVote;
    [SerializeField] GameObject Joueur02BoutonConfirmation;
    [SerializeField] GameObject Joueur02BoutonNonConfirmation;
    [SerializeField] GameObject Joueur02BoutonAVoter;
    private bool Joueur02Voter;


    [SerializeField] GameObject Joueur03BoutonVote;
    [SerializeField] GameObject Joueur03BoutonConfirmation;
    [SerializeField] GameObject Joueur03BoutonNonConfirmation;
    [SerializeField] GameObject Joueur03BoutonAVoter;
    private bool Joueur03Voter;

    [SerializeField] GameObject Joueur04BoutonVote;
    [SerializeField] GameObject Joueur04BoutonConfirmation;
    [SerializeField] GameObject Joueur04BoutonNonConfirmation;
    [SerializeField] GameObject Joueur04BoutonAVoter;
    private bool Joueur04Voter;


    [SerializeField] GameObject Joueur05BoutonVote;
    [SerializeField] GameObject Joueur05BoutonConfirmation;
    [SerializeField] GameObject Joueur05BoutonNonConfirmation;
    [SerializeField] GameObject Joueur05BoutonAVoter;
    private bool Joueur05Voter;


    [SerializeField] GameObject Joueur06BoutonVote;
    [SerializeField] GameObject Joueur06BoutonConfirmation;
    [SerializeField] GameObject Joueur06BoutonNonConfirmation;
    [SerializeField] GameObject Joueur06BoutonAVoter;
    private bool Joueur06Voter;




    [SerializeField] GameObject Joueur07BoutonVote;
    [SerializeField] GameObject Joueur07BoutonConfirmation;
    [SerializeField] GameObject Joueur07BoutonNonConfirmation;
    [SerializeField] GameObject Joueur07BoutonAVoter;
    private bool Joueur07Voter;


    [SerializeField] GameObject Joueur08BoutonVote;
    [SerializeField] GameObject Joueur08BoutonConfirmation;
    [SerializeField] GameObject Joueur08BoutonNonConfirmation;
    [SerializeField] GameObject Joueur08BoutonAVoter;
    private bool Joueur08Voter;




    [SerializeField] GameObject Joueur09BoutonVote;
    [SerializeField] GameObject Joueur09BoutonConfirmation;
    [SerializeField] GameObject Joueur09BoutonNonConfirmation;
    [SerializeField] GameObject Joueur09BoutonAVoter;
    private bool Joueur09Voter;



    [SerializeField] GameObject Joueur10BoutonVote;
    [SerializeField] GameObject Joueur10BoutonConfirmation;
    [SerializeField] GameObject Joueur10BoutonNonConfirmation;
    [SerializeField] GameObject Joueur10BoutonAVoter;
    private bool Joueur10Voter;

    private bool SabotageActif;


    [SerializeField] GameObject BoutonEmergency;
    [SerializeField] GameObject BoutonCarte;
    [SerializeField] GameObject BoutonUse;
    [SerializeField] GameObject BoutonUseGris;
    [SerializeField] GameObject Map;
    [SerializeField] GameObject MapImpo;
    [SerializeField] GameObject BoutonReport;
    [SerializeField] GameObject BoutonReportGris;



    [SerializeField] GameObject BoutonEmergencyImpo;
    [SerializeField] GameObject MapImpoSabotage;
    [SerializeField] GameObject BoutonSabotage;
    [SerializeField] GameObject BoutonKill;
    [SerializeField] GameObject BoutonVent;
    [SerializeField] GameObject BoutonVentExit;
    [SerializeField] GameObject BoutonKillGris;
    [SerializeField] GameObject BoutonNextVentillation;
    [SerializeField] GameObject QuitterBoutonSabotage;
    [SerializeField] GameObject BoutonCarteImpo;
    [SerializeField] GameObject SabotageElec;
    [SerializeField] GameObject SabotageReactor;
    [SerializeField] GameObject SabotageOxygen;
    [SerializeField] GameObject SabotageComs;
    [SerializeField] GameObject ObjetPourCOwldown;
    [SerializeField] TextMeshProUGUI CouldownKill;
    [SerializeField] GameObject BoutonReportImpo;
    [SerializeField] GameObject BoutonReportGrisImpo;


    [SerializeField] GameObject Impostor;
    [SerializeField] GameObject Crewmate;
    [SerializeField] GameObject PrimeShield;

    [SerializeField] GameObject ImpostorInterface;
    [SerializeField] GameObject CrewmateInterface;
    [SerializeField] GameObject ImpostorAffiche;
    [SerializeField] GameObject CrewmateAffiche;

    [SerializeField] GameObject JoueurMort01;
    [SerializeField] GameObject JoueurMort02;
    [SerializeField] GameObject JoueurMort03;
    [SerializeField] GameObject JoueurMort04;
    [SerializeField] GameObject JoueurMort05;
    [SerializeField] GameObject JoueurMort06;
    [SerializeField] GameObject JoueurMort07;
    [SerializeField] GameObject JoueurMort08;
    [SerializeField] GameObject JoueurMort09;
    [SerializeField] GameObject JoueurMort10;





    private float TempsAffiche = 6f;
    private bool chargement = false;
    private float TimerTuer = -1f;
    private float SabotageSonTimer = 10f;
    private bool SonVictoireCrewmate = false;
    private bool SonVictoireImposteur = false;


    // Start is called before the first frame update
    void Start()
    {
        RandomIntPourRole();
        
    }

    // Update is called once per frame
    void Update()
    {
        BoutonKillChangement();
        BoutonKillCowldown();
        
        AfficherCouldown();

        TimerCowldown();

        BoutonUseChangement();
        BoutonVentil();
        BoutonVentilExit();
        ImposteurReport();
        FinInterfaceReport();
        TempsAffichageRole();
        EmergencyMettingImpo(); 
        EmergencyMettingCrewmate();
        if (DecompteNoVote == true)
        {
            TempsPourVoter();
        }

        SabotageSonSon();
        VictoryCrewmateScreen();
        VictoryImpostorScreen();


        // Debug.Log("Valeur bool Chargement = " + chargement);
        //Debug.Log("Valeur TempsChargement = " + TimerTuer);
    }


    public void TeleportAprsVote()
    {
        UnityEngine.Debug.Log("Je téléporte");
        Joueur01.GetComponent<CharacterController>().enabled = false;
        Joueur01.transform.position = new Vector3(142f, 0.3f, -4f);
        Joueur01.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        Joueur01.GetComponent<CharacterController>().enabled = true;
    }



    public void TempsAffichageRole()
    {
        bool Debut = false;
        TempsAffiche = TempsAffiche - Time.deltaTime;
        //UnityEngine.Debug.Log(TempsAffiche);
        
        if (TempsAffiche < 0 && Debut == false)
        {
            Debut = true;
            CrewmateAffiche.SetActive(false);
            ImpostorAffiche.SetActive(false);
            MapIA.enabled = true;
        }
    }

    public void RandomIntPourRole()
    {
        int RandomIntRole;
       

        RandomIntRole = UnityEngine.Random.Range(0, 2);
        UnityEngine.Debug.Log(RandomIntRole);

        if (RandomIntRole == 0) 
        {
            CrewmateInterface.SetActive(true);
            CrewmateAffiche.SetActive(true);
            ImpostorInterface.SetActive(false);
            UnityEngine.Debug.Log("Ici01");
            

        }
        else if (RandomIntRole == 1)
        {
            CrewmateInterface.SetActive(false);
            ImpostorAffiche.SetActive(true);
            ImpostorInterface.SetActive(true);
            UnityEngine.Debug.Log("Ici02");
        }

    }





    public void TempsPourVoter()
    {
        UnityEngine.Debug.Log("DecompteNoVote");
        if ((TempsAvantFinVote >= 0) && DecompteNoVote == true)
        {
            TempsAvantFinVote = TempsAvantFinVote - Time.deltaTime;
            UnityEngine.Debug.Log("TempsAvantFinVote");
            int TempsBis = Mathf.RoundToInt(TempsAvantFinVote);

            TempsVote.GetComponent<TMP_Text>().text = TempsBis.ToString();
            ApreVoteBlocage.SetActive(true);

        }

        if ((TempsAvantFinVote <= 0))
        {
            Decompte = true;
            DecompteNoVote = false;
            FinInterfaceReport();
            ApreVoteBlocage.SetActive(false);


        }
    }

    public void AfficherInterfaceReportEmergency()
    {
        EnsembleReportIntrface.SetActive(true);
        DecompteNoVote = true;
        LesSons.PlayOneShot(EmergencySound);

        if (Joueur01.activeSelf == false)
        {
            JoueurMort01.SetActive(true);
        }
        if (Joueur02.activeSelf == false)
        {
            JoueurMort02.SetActive(true);
        }
        if (Joueur03.activeSelf == false)
        {
            JoueurMort03.SetActive(true);
        }
        if (Joueur04.activeSelf == false)
        {
            JoueurMort04.SetActive(true);
        }
        if (Joueur05.activeSelf == false)
        {
            JoueurMort05.SetActive(true);
        }
        if (Joueur06.activeSelf == false)
        {
            JoueurMort06.SetActive(true);
        }
        if (Joueur07.activeSelf == false)
        {
            JoueurMort07.SetActive(true);
        }
        if (Joueur08.activeSelf == false)
        {
            JoueurMort08.SetActive(true);
        }
        if (Joueur09.activeSelf == false)
        {
            JoueurMort09.SetActive(true);
        }
        if (Joueur10.activeSelf == false)
        {
            JoueurMort10.SetActive(true);
        }


    }

    public void RetourMenuPrincipale()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void AfficherInterfaceReport()
    {
        EnsembleReportIntrface.SetActive(true);
        DecompteNoVote = true;
        LesSons.PlayOneShot(ReportBodySound);

        if (Joueur01.activeSelf == false)
        {
            JoueurMort01.SetActive(true);
        }
        if (Joueur02.activeSelf == false)
        {
            JoueurMort02.SetActive(true);
        }
        if (Joueur03.activeSelf == false)
        {
            JoueurMort03.SetActive(true);
        }
        if(Joueur04.activeSelf == false)
        {
            JoueurMort04.SetActive(true);
        }
        if(Joueur05.activeSelf == false)
        {
            JoueurMort05.SetActive(true);
        }
        if(Joueur06.activeSelf == false)
        {
            JoueurMort06.SetActive(true);
        }
        if(Joueur07.activeSelf == false)
        {
            JoueurMort07.SetActive(true);
        }
        if(Joueur08.activeSelf == false)
        {
            JoueurMort08.SetActive(true);
        }
        if(Joueur09.activeSelf == false)
        {
            JoueurMort09.SetActive(true);
        }
        if(Joueur10.activeSelf == false)
        {
            JoueurMort10.SetActive(true);
        }


    }



    public void VictoryCrewmateScreen()
    {
        if (PrimeShield.GetComponent<ScriptPrimeShield>().FinTacheReturn() == true && SonVictoireCrewmate == false)
        {
            SonVictoireCrewmate = true;
            VictoryCrewmate.SetActive(true);
            VictorySound.SetActive(true);
        }
    }

    public void VictoryImpostorScreen()
    {
        if (Joueur02.activeSelf == false && Joueur03.activeSelf == false && Joueur04.activeSelf == false && Joueur05.activeSelf == false && Joueur06.activeSelf == false && Joueur07.activeSelf == false && Joueur08.activeSelf == false && Joueur09.activeSelf == false && Joueur10.activeSelf == false && SonVictoireImposteur == false)
        {
            SonVictoireImposteur = true;
            VictoryImpostor.SetActive(true);
            VictorySoundImpostor.SetActive(true);
        }
    }




    public void FinInterfaceReport()
    {
        if ( (TempsAvantFinInterfaceReport >= 0) && Decompte == true)
        {
            TempsAvantFinInterfaceReport = TempsAvantFinInterfaceReport - Time.deltaTime;
            UnityEngine.Debug.Log("TempsAvantFinInterfaceReport");
            int TempsBis = Mathf.RoundToInt(TempsAvantFinInterfaceReport);

            TempsVote.GetComponent<TMP_Text>().text = TempsBis.ToString();

        }
        if ((TempsAvantFinInterfaceReport <= 0))
        {
            EnsembleReportIntrface.SetActive(false);

            JoueurMort01.SetActive(false);
            JoueurMort02.SetActive(false);
            JoueurMort03.SetActive(false);
            JoueurMort04.SetActive(false);
            JoueurMort05.SetActive(false);
            JoueurMort06.SetActive(false);
            JoueurMort07.SetActive(false);
            JoueurMort08.SetActive(false);
            JoueurMort09.SetActive(false);
            JoueurMort10.SetActive(false);



            Impostor.GetComponent<PlayerImpostor>().SetCorpsApresVote();
            foreach (Transform child in Cadavre.transform)
            {
                Destroy(child.gameObject);
            }

            Decompte = false;
            Joueur01BoutonAVoter.SetActive(false);
            BoutonReportGrisImpo.SetActive(true);
            BoutonReportImpo.SetActive(false);

            ApreVoteBlocage.SetActive(false);
            TempsAvantFinInterfaceReport = 20f;
            if (Joueur01Voter == true)
            {
                Joueur01.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur02Voter == true )
            {
                Joueur02.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur03Voter == true) 
            {
                Joueur03.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur04Voter == true)
            {
                Joueur04.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur05Voter == true)
            {
                Joueur05.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur06Voter == true)
            {
                Joueur06.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur07Voter == true)
            {
                Joueur07.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur08Voter == true)
            {
                Joueur08.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur09Voter == true)
            {
                Joueur09.SetActive(false);
                TeleportAprsVote();

            }
            else if (Joueur10Voter == true)
            {
                Joueur10.SetActive(false);
                TeleportAprsVote();

            }
            TeleportAprsVote();
        }
    }

    public void ImposteurReport()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ReturnCorps() == true)
        {
            BoutonReportImpo.SetActive(true);
            BoutonReportGrisImpo.SetActive(false);
        }
        if (Impostor.GetComponent<PlayerImpostor>().ReturnCorps() == false)
        {
            BoutonReportGrisImpo.SetActive(true);
            BoutonReportImpo.SetActive(false);
        }
    }

    public void BoutonSkipVote()
    {

        ApreVoteBlocage.SetActive(true);

        UnityEngine.Debug.Log("Valeur Joueur Voté = Personne");
        Decompte = true;

        FinInterfaceReport();
        TeleportAprsVote();
    }


    public void BoutonJoueur01Vote()
    {

        if (Joueur01.activeSelf == true)
        {
            Joueur01BoutonConfirmation.SetActive(true);
            Joueur01BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur01.activeSelf == false)
        {
            Joueur01BoutonVote.SetActive(false);
            JoueurMort01.SetActive(true);

        }

    }
    public void BoutonJoueur01VoteNotConfirmation()
    {
        Joueur01BoutonConfirmation.SetActive(false);
        Joueur01BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur01VoteConfirmation()
    {
        Joueur01BoutonConfirmation.SetActive(false);
        Joueur01BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        ApreVoteBlocage.SetActive(true);
        Joueur01Voter = true;
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur01Voter);
        Decompte = true;
        
        FinInterfaceReport();
    }

    public void BoutonJoueur02Vote()
    {
        if (Joueur02.activeSelf == true)
        {
            Joueur02BoutonConfirmation.SetActive(true);
            Joueur02BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur02.activeSelf == false)
        {
            Joueur02BoutonVote.SetActive(false);
            JoueurMort02.SetActive(true);

        }

    }
    public void BoutonJoueur02VoteNotConfirmation()
    {
        Joueur02BoutonConfirmation.SetActive(false);
        Joueur02BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur02VoteConfirmation()
    {
        Joueur02BoutonConfirmation.SetActive(false);
        Joueur02BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        ApreVoteBlocage.SetActive(true);

        Joueur02Voter = true;
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur02Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur03Vote()
    {
        if (Joueur03.activeSelf == true)
        {
            Joueur03BoutonConfirmation.SetActive(true);
            Joueur03BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur03.activeSelf == false)
        {
            Joueur03BoutonVote.SetActive(false);
            JoueurMort03.SetActive(true);

        }
    }
    public void BoutonJoueur03VoteNotConfirmation()
    {
        Joueur03BoutonConfirmation.SetActive(false);
        Joueur03BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur03VoteConfirmation()
    {
        Joueur03BoutonConfirmation.SetActive(false);
        Joueur02BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        ApreVoteBlocage.SetActive(true);
        Joueur03Voter = true;
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur03Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur04Vote()
    {
        if (Joueur04.activeSelf == true)
        {
            Joueur04BoutonConfirmation.SetActive(true);
            Joueur04BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur04.activeSelf == false)
        {
            Joueur04BoutonVote.SetActive(false);
            JoueurMort04.SetActive(true);

        }
    }
    public void BoutonJoueur04VoteNotConfirmation()
    {
        Joueur04BoutonConfirmation.SetActive(false);
        Joueur04BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur04VoteConfirmation()
    {
        Joueur04BoutonConfirmation.SetActive(false);
        Joueur04BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        ApreVoteBlocage.SetActive(true);
        Joueur04Voter = true;
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur04Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur05Vote()
    {
        if (Joueur05.activeSelf == true)
        {
            Joueur05BoutonConfirmation.SetActive(true);
            Joueur05BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur05.activeSelf == false)
        {
            Joueur05BoutonVote.SetActive(false);
            JoueurMort05.SetActive(true);

        }
    }
    public void BoutonJoueur05VoteNotConfirmation()
    {
        Joueur05BoutonConfirmation.SetActive(false);
        Joueur05BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur05VoteConfirmation()
    {
        Joueur05BoutonConfirmation.SetActive(false);
        Joueur05BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur05Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur05Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur06Vote()
    {
        if (Joueur06.activeSelf == true)
        {
            Joueur06BoutonConfirmation.SetActive(true);
            Joueur06BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur06.activeSelf == false)
        {
            Joueur06BoutonVote.SetActive(false);
            JoueurMort06.SetActive(true);

        }
    }
    public void BoutonJoueur06VoteNotConfirmation()
    {
        Joueur06BoutonConfirmation.SetActive(false);
        Joueur06BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur06VoteConfirmation()
    {
        Joueur06BoutonConfirmation.SetActive(false);
        Joueur06BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur06Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur06Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur07Vote()
    {
        if (Joueur07.activeSelf == true)
        {
            Joueur07BoutonConfirmation.SetActive(true);
            Joueur07BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur07.activeSelf == false)
        {
            Joueur07BoutonVote.SetActive(false);
            JoueurMort07.SetActive(true);

        }
    }
    public void BoutonJoueur07VoteNotConfirmation()
    {
        Joueur07BoutonConfirmation.SetActive(false);
        Joueur07BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur07VoteConfirmation()
    {
        Joueur07BoutonConfirmation.SetActive(false);
        Joueur07BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur07Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur07Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur08Vote()
    {
        if (Joueur08.activeSelf == true)
        {
            Joueur08BoutonConfirmation.SetActive(true);
            Joueur08BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur08.activeSelf == false)
        {
            Joueur08BoutonVote.SetActive(false);
            JoueurMort08.SetActive(true);

        }
    }
    public void BoutonJoueur08VoteNotConfirmation()
    {
        Joueur08BoutonConfirmation.SetActive(false);
        Joueur08BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur08VoteConfirmation()
    {
        Joueur08BoutonConfirmation.SetActive(false);
        Joueur08BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur08Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur08Voter);
        Decompte = true;

        FinInterfaceReport();
    }

    public void BoutonJoueur09Vote()
    {
        if (Joueur09.activeSelf == true)
        {
            Joueur09BoutonConfirmation.SetActive(true);
            Joueur09BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur09.activeSelf == false)
        {
            Joueur09BoutonVote.SetActive(false);
            JoueurMort09.SetActive(true);

        }
    }
    public void BoutonJoueur09VoteNotConfirmation()
    {

        Joueur09BoutonConfirmation.SetActive(false);
        Joueur09BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur09VoteConfirmation()
    {
        Joueur09BoutonConfirmation.SetActive(false);
        Joueur09BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur09Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur09Voter);
        Decompte = true;

        FinInterfaceReport();
    }


    public void BoutonJoueur10Vote()
    {
        if (Joueur10.activeSelf == true)
        {
            Joueur10BoutonConfirmation.SetActive(true);
            Joueur10BoutonNonConfirmation.SetActive(true);
        }
        else if (Joueur10.activeSelf == false)
        {
            Joueur10BoutonVote.SetActive(false);
            JoueurMort10.SetActive(true);
        }
    }
    public void BoutonJoueur10VoteNotConfirmation()
    {
        Joueur10BoutonConfirmation.SetActive(false);
        Joueur10BoutonNonConfirmation.SetActive(false);
    }
    public void BoutonJoueur10VoteConfirmation()
    {
        Joueur10BoutonConfirmation.SetActive(false);
        Joueur10BoutonNonConfirmation.SetActive(false);
        Joueur01BoutonAVoter.SetActive(true);
        Joueur10Voter = true;
        ApreVoteBlocage.SetActive(true);
        UnityEngine.Debug.Log("Valeur Joueur Voté = " + Joueur10Voter);
        Decompte = true;

        FinInterfaceReport();
    }


    public void BoutonUseChangement()
    {
        if (Crewmate.GetComponent<PlayerCrewmate>().ReturnUtiliser() == true)
        {
            BoutonUse.SetActive(true);
            BoutonUseGris.SetActive(false);
        }
        else if (Crewmate.GetComponent<PlayerCrewmate>().ReturnUtiliser() == false)
        {
            BoutonUse.SetActive(false);
            BoutonUseGris.SetActive(true);
        }
    }

    public void BoutonVentil()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ValeurVentillation() == true )
        {
            BoutonSabotage.SetActive(false);
            BoutonVent.SetActive(true);
            Impostor.GetComponent<PlayerImpostor>().estEnVentillationOui();

        }
        else if (Impostor.GetComponent<PlayerImpostor>().ValeurBoutonVentillation() == false )
        {
            BoutonSabotage.SetActive(true);
            BoutonVent.SetActive(false);
 
            Impostor.GetComponent<PlayerImpostor>().estEnVentillationNon();
            

        }
    }

    public void EmergencyMettingImpo()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ReturnEmergency() == true && Impostor.GetComponent<PlayerImpostor>().ValeurVentillation() == false)
        {
            BoutonSabotage.SetActive(false);
            BoutonEmergencyImpo.SetActive(true);
            
        }
        else if (Impostor.GetComponent<PlayerImpostor>().ReturnEmergency() == false && Impostor.GetComponent<PlayerImpostor>().ValeurVentillation() == false)
        {
            BoutonSabotage.SetActive(true);
            BoutonEmergencyImpo.SetActive(false);
        }
    }


    public void EmergencyMettingCrewmate()
    {
        if (Crewmate.GetComponent<PlayerCrewmate>().ReturnEmergency() == true)
        {
            BoutonUseGris.SetActive(false);
            BoutonEmergency.SetActive(true);
            
        }
        else if (Crewmate.GetComponent<PlayerCrewmate>().ReturnEmergency() == false)
        {
            BoutonUseGris.SetActive(true);
            BoutonEmergency.SetActive(false);
        }
    }


    public void VoyageVentillation()
    {

        LesSons.PlayOneShot(NextVent);

        if(Impostor.GetComponent<PlayerImpostor>().CameraVetilation01() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent02();
        }
        else if(Impostor.GetComponent<PlayerImpostor>().CameraVetilation02() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent03();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation03() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent04();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation04() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent05();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation05() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent06();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation06() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent07();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation07() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent08();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation08() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent09();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation09() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent10();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation10() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageVersVent11();
        }
        else if (Impostor.GetComponent<PlayerImpostor>().CameraVetilation11() == true)
        {
            Impostor.GetComponent<PlayerImpostor>().VentVoyageersVent01();
        }

    }


    public void SabotageSonClick()
    {
        if(SabotageActif == false)
        {
            SabotageActif = true;
            SonSabotage.SetActive(true);
            
        }
    }


    public void SabotageSonSon()
    {
        if (SabotageSonTimer > 0f && SabotageActif == true)
        {
    
            SabotageSonTimer = SabotageSonTimer - Time.deltaTime;
            int SabotageSonTimerBis = Mathf.FloorToInt(SabotageSonTimer);
            UnityEngine.Debug.Log(SabotageSonTimer.ToString());

            if ((SabotageSonTimerBis%2 == 1))
            {
                RougeSabotage.SetActive(true);
            }
            else if (!(SabotageSonTimerBis % 2 == 1))
            {
                RougeSabotage.SetActive(false);
            }
        }

        if (SabotageSonTimer <= 0f)
        {

            SabotageActif = false;
            SonSabotage.SetActive(false);
            RougeSabotage.SetActive(false);
            SabotageSonTimer = 10f;
        }
    }





    public void BoutonVentilExit()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ValeurBoutonVentillation() == true && Impostor.GetComponent<PlayerImpostor>().ValeurVentillation() == true)
        {
            
            BoutonVent.SetActive(false);
            BoutonNextVentillation.SetActive(true);
            BoutonVentExit.SetActive(true);


        }
        else if (Impostor.GetComponent<PlayerImpostor>().ValeurBoutonVentillation() == false && Impostor.GetComponent<PlayerImpostor>().ValeurVentillation() == true)
        {
            BoutonVentExit.SetActive(false);
            BoutonNextVentillation.SetActive(false);

            BoutonVent.SetActive(true);
            Impostor.GetComponent<PlayerImpostor>().CameraHorsVentillation();

        }
    }



    public void AfficherCouldown()
    {
        if (chargement == true) 
        {
            ObjetPourCOwldown.SetActive(true);
        }
        else if (chargement == false)
        {
            ObjetPourCOwldown.SetActive(false);
        }
    }



    public void TimerCowldown()
    {
        if (chargement == true)
        {
            TimerTuer = TimerTuer - Time.deltaTime;
        }

        if (TimerTuer <= 0)
        {
            chargement = false;
        }

        int TimerBis = Mathf.RoundToInt(TimerTuer);


        CouldownKill.GetComponent<TMP_Text>().text = TimerBis.ToString();

    }


    public bool ValeurChargement()
    {
        return chargement;
    }

    public void BoutonKillCowldown()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ValeurKill() == true && Impostor.GetComponent<PlayerImpostor>().ValeurBoutonTuer() == true && TimerTuer <= 0)
        {
            BoutonKill.SetActive(false);
            chargement = true;
            TimerTuer = 5f;
            BoutonKillGris.SetActive(true);
        }
    }


    public void BoutonKillChangement()
    {
        if (Impostor.GetComponent<PlayerImpostor>().ValeurKill() == true && chargement == false)
        {
            BoutonKill.SetActive(true);
            BoutonKillGris.SetActive(false);
        }
        else if (Impostor.GetComponent<PlayerImpostor>().ValeurKill() == false && chargement == false)
        {
            BoutonKill.SetActive(false);
            BoutonKillGris.SetActive(true);
        }
 
    }

    public void OuvrirCarte()
    {
        BoutonCarte.SetActive(true);
        Map.SetActive(true);
    }

    public void OuvrirCarteImpo()
    {
        BoutonCarteImpo.SetActive(true);
        MapImpo.SetActive(true);
    }

    public void FermerCarteImpo()
    {
        BoutonCarteImpo.SetActive(false);
        MapImpo.SetActive(false);
    }

    public void FermerCarte()
    {
        BoutonCarte.SetActive(false);
        Map.SetActive(false);
    }

    public void OuvrirSabotage()
    {
        
        SabotageElec.SetActive(true);
        SabotageOxygen.SetActive(true);
        SabotageReactor.SetActive(true);
        SabotageComs.SetActive(true);
        QuitterBoutonSabotage.SetActive(true);

        MapImpoSabotage.SetActive(true);
    }


    public void FermerSabotage()
    {
        
        SabotageElec.SetActive(false);
        SabotageOxygen.SetActive(false);
        SabotageReactor.SetActive(false);
        SabotageComs.SetActive(false);
        QuitterBoutonSabotage.SetActive(false);

        MapImpoSabotage.SetActive(false);
    }





}
