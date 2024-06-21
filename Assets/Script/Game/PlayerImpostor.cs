using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpostor : MonoBehaviour
{
    private bool Kill = false;
    private bool actionTuer = false;
    private bool Ventillation = false;
    private bool actionVentillation = false;
    private bool BoolCameraVentillation01 = false;
    private bool BoolCameraVentillation02 = false;
    private bool BoolCameraVentillation03 = false;
    private bool BoolCameraVentillation04 = false;
    private bool BoolCameraVentillation05 = false;
    private bool BoolCameraVentillation06 = false;
    private bool BoolCameraVentillation07 = false;
    private bool BoolCameraVentillation08 = false;
    private bool BoolCameraVentillation09 = false;
    private bool BoolCameraVentillation10 = false;
    private bool BoolCameraVentillation11 = false;

    private bool LaunchPadMusic = false;
    private bool LaboMusic = false;
    private bool ReactorMusic = false;
    private bool MedbayMusic = false;
    private bool ComMusic = false;
    private bool AdminMusic = false;
    private bool OfficeMusic = false;
    private bool GreenMusic = false;
    private bool CafetariaMusic = false;
    private bool StorageMusic = false;
    private bool LockerMusic = false;
    private bool CouloirMusic = false;

    private bool Corps = false;
    private bool Emergency = false;

    private bool estEnVentillation = false;

    [SerializeField] GameObject Cadavre;

    [SerializeField] GameObject UiManager;
    [SerializeField] GameObject CameraVentillation01;
    [SerializeField] GameObject CameraVentillation02;
    [SerializeField] GameObject CameraVentillation03;
    [SerializeField] GameObject CameraVentillation04;
    [SerializeField] GameObject CameraVentillation05;
    [SerializeField] GameObject CameraVentillation06;
    [SerializeField] GameObject CameraVentillation07;
    [SerializeField] GameObject CameraVentillation08;
    [SerializeField] GameObject CameraVentillation09;
    [SerializeField] GameObject CameraVentillation10;
    [SerializeField] GameObject CameraVentillation11;
    [SerializeField] GameObject CameraGeneral;
    [SerializeField] GameObject PrefabCorps;
    [SerializeField] GameObject Joueur;
    [SerializeField] GameObject JoueurCorpsVisibilite;


    [SerializeField] AudioSource LesSons;
    [SerializeField] AudioClip KillSound;
    [SerializeField] AudioClip VentInSound;
    [SerializeField] AudioClip VentOutSound;
    [SerializeField] GameObject SoundLaunchPad;
    [SerializeField] GameObject SoundLabo;
    [SerializeField] GameObject SoundReactor;
    [SerializeField] GameObject SoundMedbay;
    [SerializeField] GameObject SoundCom;
    [SerializeField] GameObject SoundAdmin;
    [SerializeField] GameObject SoundOffice;
    [SerializeField] GameObject SoundGreen;
    [SerializeField] GameObject SoundCafetaria;
    [SerializeField] GameObject SoundStorage;
    [SerializeField] GameObject SoundLocker;
    [SerializeField] GameObject SoundCouloir;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Valeur bool Kill = " + Kill);
        //Debug.Log("Valeur bool actionTuer = " + actionTuer);
        //Debug.Log("Action ventillation = "+ actionVentillation);
        //Debug.Log("Action estVentillation = " + estEnVentillation);
        //Debug.Log("Action Ventillation = " + Ventillation);
        //Debug.Log("Valeur Bool Corps = + " + Corps);
    }

    public bool ReturnCorps()
    {
        return Corps;
    }

    public bool ReturnEmergency()
    {
        return Emergency;
    }

    public void SetCorpsApresVote()
    {
        Corps = false;
    }


    public void VentVoyageVersVent02()
    {
        
            Debug.Log("Appuyé pour aller vent 02");
            BoolCameraVentillation01 = false;
            BoolCameraVentillation02 = true;
            Joueur.GetComponent<CharacterController>().enabled = false;
            Joueur.transform.position = new Vector3(50.71f, 0.3f, -2.37f);
            Joueur.GetComponent<CharacterController>().enabled = true;

    }

    public void VentVoyageVersVent03()
    {

        Debug.Log("Appuyé pour aller vent 03");
        BoolCameraVentillation02 = false;
        BoolCameraVentillation03 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(95.98f, 0.3f, 3.83f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation03.SetActive(true);
        CameraVentillation02.SetActive(false);

    }

    public void VentVoyageVersVent04()
    {

        Debug.Log("Appuyé pour aller vent 04");
        BoolCameraVentillation03 = false;
        BoolCameraVentillation04 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(142.973f, 0.3f, -15.929f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation04.SetActive(true);
        CameraVentillation03.SetActive(false);

    }

    public void VentVoyageVersVent05()
    {

        Debug.Log("Appuyé pour aller vent 05");
        BoolCameraVentillation04 = false;
        BoolCameraVentillation05 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(133.49f, 0.3f, 27.48f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation05.SetActive(true);
        CameraVentillation04.SetActive(false);

    }

    public void VentVoyageVersVent06()
    {

        Debug.Log("Appuyé pour aller vent 06");
        BoolCameraVentillation05 = false;
        BoolCameraVentillation06 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(120.03f, 0.3f, 80.92f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation06.SetActive(true);
        CameraVentillation05.SetActive(false);

    }

    public void VentVoyageVersVent07()
    {

        Debug.Log("Appuyé pour aller vent 07");
        BoolCameraVentillation06 = false;
        BoolCameraVentillation07 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(106.273f, 0.3f, 99.941f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation07.SetActive(true);
        CameraVentillation06.SetActive(false);

    }

    public void VentVoyageVersVent08()
    {

        Debug.Log("Appuyé pour aller vent 08");
        BoolCameraVentillation07 = false;
        BoolCameraVentillation08 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(92.38f, 0.3f, 79.74f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation08.SetActive(true);
        CameraVentillation07.SetActive(false);

    }

    public void VentVoyageVersVent09()
    {

        Debug.Log("Appuyé pour aller vent 09");
        BoolCameraVentillation08 = false;
        BoolCameraVentillation09 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(78.51f, 0.3f, 71.02f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation09.SetActive(true);
        CameraVentillation08.SetActive(false);

    }

    public void VentVoyageVersVent10()
    {

        Debug.Log("Appuyé pour aller vent 10");
        BoolCameraVentillation09 = false;
        BoolCameraVentillation10 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(32.093f, 0.3f, 44.761f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation10.SetActive(true);
        CameraVentillation09.SetActive(false);

    }

    public void VentVoyageVersVent11()
    {

        Debug.Log("Appuyé pour aller vent 11");
        BoolCameraVentillation10 = false;
        BoolCameraVentillation11 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(60.06f, 0.3f, 4.69f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation11.SetActive(true);
        CameraVentillation10.SetActive(false);

    }


    public void VentVoyageersVent01()
    {

        Debug.Log("Appuyé pour aller vent 01");
        BoolCameraVentillation11 = false;
        BoolCameraVentillation01 = true;
        Joueur.GetComponent<CharacterController>().enabled = false;
        Joueur.transform.position = new Vector3(2.199739f, 0.3f, 2.373702f);
        Joueur.GetComponent<CharacterController>().enabled = true;
        CameraVentillation01.SetActive(true);
        CameraVentillation11.SetActive(false);

    }

    public void estEnVentillationOui()
    {
        estEnVentillation = true;
    }

    public void estEnVentillationNon()
    {

        estEnVentillation = false;
        JoueurCorpsVisibilite.SetActive(true);
    }

    public bool CameraVetilation01()
    {
        return BoolCameraVentillation01;
    }

    public bool CameraVetilation02()
    {
        return BoolCameraVentillation02;
    }

    public bool CameraVetilation03()
    {
        return BoolCameraVentillation03;
    }

    public bool CameraVetilation04()
    {
        return BoolCameraVentillation04;
    }

    public bool CameraVetilation05()
    {
        return BoolCameraVentillation05;
    }

    public bool CameraVetilation06()
    {
        return BoolCameraVentillation06;
    }

    public bool CameraVetilation07()
    {
        return BoolCameraVentillation07;
    }

    public bool CameraVetilation08()
    {
        return BoolCameraVentillation08;
    }

    public bool CameraVetilation09()
    {
        return BoolCameraVentillation09;
    }

    public bool CameraVetilation10()
    {
        return BoolCameraVentillation10;
    }

    public bool CameraVetilation11()
    {
        return BoolCameraVentillation11;
    }


    public bool ValeurKill()
    {
        return Kill;
    }

    public bool ValeurVentillation()
    {
        return Ventillation;
    }

    public bool ValeurBoutonTuer()
    {
        return actionTuer;
    }

    public bool ValeurBoutonVentillation()
    {
        return actionVentillation;
    }

    public void PressVentillation()
    {
        if (actionVentillation == false)
        {
            LesSons.PlayOneShot(VentInSound);
            actionVentillation = true;
            Debug.Log("J'appui pour ventiller");
        }
    }

    public void CameraHorsVentillation()
    {
        
            JoueurCorpsVisibilite.SetActive(true);
            CameraGeneral.SetActive(true);
            CameraVentillation01.SetActive(false);
            CameraVentillation02.SetActive(false);
            CameraVentillation03.SetActive(false);
            CameraVentillation04.SetActive(false);
            CameraVentillation05.SetActive(false);
            CameraVentillation06.SetActive(false);
            CameraVentillation07.SetActive(false);
            CameraVentillation08.SetActive(false);
            CameraVentillation09.SetActive(false);
            CameraVentillation10.SetActive(false);
            CameraVentillation11.SetActive(false);

    }


    public void RelaseadPressButtonVentillation()
    {
        if(actionVentillation == true)
        {
            LesSons.PlayOneShot(VentOutSound);
            actionVentillation = false;
            Debug.Log("Je relache pour ne plus pour ventiller");
        }

    }

    public void PressButton()
    {
        actionTuer = true;
        Debug.Log("J'appui pour tuer");
        LesSons.PlayOneShot(KillSound);

        
    }

    public void RelaseadPressButton()
    {
        actionTuer = false;
        Debug.Log("Je relache pour ne plus tuer");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Crewmate")
        {
            Debug.Log("Je peux tuer");
            Kill = true;
            if ( Kill == true && actionTuer == true )
            {
                Instantiate(PrefabCorps, new Vector3(other.transform.position.x, other.transform.position.y+0.2f, other.transform.position.z), Quaternion.Euler(90f, 0f, 0f)).transform.parent = Cadavre.transform;

                
                other.gameObject.SetActive(false);
                Kill = false;
                actionTuer = false;
            }
        }

        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent01")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation01.SetActive(true);
                BoolCameraVentillation01 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent02")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation02.SetActive(true);
                BoolCameraVentillation02 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent03")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation03.SetActive(true);
                BoolCameraVentillation03 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent04")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation04.SetActive(true);
                BoolCameraVentillation04 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent05")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation05.SetActive(true);
                BoolCameraVentillation05 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent06")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation06.SetActive(true);
                BoolCameraVentillation06 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent07")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation07.SetActive(true);
                BoolCameraVentillation07 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent08")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation08.SetActive(true);
                BoolCameraVentillation08 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent09")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation09.SetActive(true);
                BoolCameraVentillation09 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent10")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation10.SetActive(true);
                BoolCameraVentillation10 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent11")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation11.SetActive(true);
                BoolCameraVentillation11 = true;


            }
        }

        if (other.gameObject.tag == "Corps")
        {
            Debug.Log("Je touche un cadavre");
            Corps = true;
        }

        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je touche boutonEmergency");
            Emergency = true;
        }


        if (other.gameObject.tag == "Son" && other.gameObject.name == "LaunchPadContact" && LaunchPadMusic == false)
        {
            Debug.Log("Je launch Music Pad");
            LaunchPadMusic = true;
            SoundLaunchPad.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "LaboContact" && LaboMusic == false)
        {
            Debug.Log("Jentre Music Labo");
            LaboMusic = true;
            SoundLabo.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "ReactorContact" && ReactorMusic == false)
        {
            Debug.Log("Jentre Music Reactor");
            ReactorMusic = true;
            SoundReactor.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "MedbayContact" && MedbayMusic == false)
        {
            Debug.Log("Jentre Music MedbayMusic");
            MedbayMusic = true;
            SoundMedbay.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "ComContact" && ComMusic == false)
        {
            Debug.Log("Jentre Music ComMusic");
            ComMusic = true;
            SoundCom.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "AdminContact" && AdminMusic == false)
        {
            Debug.Log("Jentre Music AdminMusic");
            AdminMusic = true;
            SoundAdmin.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "OfficeContact" && OfficeMusic == false)
        {
            Debug.Log("Jentre Music OfficeMusic");
            OfficeMusic = true;
            SoundOffice.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "GreenContact" && GreenMusic == false)
        {
            Debug.Log("Jentre Music GreenMusic");
            GreenMusic = true;
            SoundGreen.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "CafetariaContact" || other.gameObject.name == "Cafetaria2Contact" && CafetariaMusic == false)
        {
            Debug.Log("Jentre Music CafetariaMusic");
            CafetariaMusic = true;
            SoundCafetaria.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "StroageContact" && StorageMusic == false)
        {
            Debug.Log("Jentre Music StorageMusic");
            StorageMusic = true;
            SoundStorage.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "LockerContact" && LockerMusic == false)
        {
            Debug.Log("Jentre Music StorageMusic");
            LockerMusic = true;
            SoundLocker.SetActive(true);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "CouloirContact01" || other.gameObject.name == "CouloirContact02" || other.gameObject.name == "CouloirContact03" || other.gameObject.name == "CouloirContact04" || other.gameObject.name == "CouloirContact05" || other.gameObject.name == "CouloirContact06" && CouloirMusic == false)
        {
            Debug.Log("Jentre Music CafetariaMusic");
            CouloirMusic = true;
            SoundCouloir.SetActive(true);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Crewmate")
        {
            Debug.Log("Je peux tuer (STay)");
            Kill = true;
            if (Kill == true && actionTuer == true )
            {
                Instantiate(PrefabCorps, new Vector3(other.transform.position.x, other.transform.position.y+0.2f, other.transform.position.z), Quaternion.Euler(90f, 0f, 0f)).transform.parent = Cadavre.transform;

                other.gameObject.SetActive(false);
                Kill = false;
                actionTuer = false;
                CameraShake.Instance.ShakeCamera(4f, 0.3f);

            }
        }

        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent01")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation01.SetActive(true);
                BoolCameraVentillation01 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent02")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation02.SetActive(true);
                BoolCameraVentillation02 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent03")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation03.SetActive(true);
                BoolCameraVentillation03 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent04")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation04.SetActive(true);
                BoolCameraVentillation04 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent05")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation05.SetActive(true);
                BoolCameraVentillation05 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent06")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation06.SetActive(true);
                BoolCameraVentillation06 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent07")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation07.SetActive(true);
                BoolCameraVentillation07 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent08")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation08.SetActive(true);
                BoolCameraVentillation08 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent09")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation09.SetActive(true);
                BoolCameraVentillation09 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent10")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation10.SetActive(true);
                BoolCameraVentillation10 = true;


            }
        }
        if (other.gameObject.tag == "Vent" && other.gameObject.name == "Vent11")
        {
            Debug.Log("Je Suis sur une ventillation");
            Ventillation = true;

            if (Ventillation == true && actionVentillation == true && estEnVentillation == true)
            {

                JoueurCorpsVisibilite.SetActive(false);
                CameraGeneral.SetActive(false);
                CameraVentillation11.SetActive(true);
                BoolCameraVentillation11 = true;


            }
        }

        if (other.gameObject.tag == "Corps")
        {
            Debug.Log("Je touche un cadavre");
            Corps = true;
        }

        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je touche boutonEmergency");
            Emergency = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Crewmate")
        {
            Debug.Log("Je Sort (Exit)");
            Kill = false;
        }

        if (other.gameObject.tag == "Vent")
        {
            Debug.Log("Je ne Suis plus sur une ventillation");
            Ventillation = false;
            /*Joueur.SetActive(true);
            CameraGeneral.SetActive(true);
            CameraVentillation02.SetActive(false);
            CameraVentillation01.SetActive(false);*/
            BoolCameraVentillation01 = false;
            BoolCameraVentillation02 = false;
            BoolCameraVentillation03 = false;
            BoolCameraVentillation04 = false;
            BoolCameraVentillation05 = false;
            BoolCameraVentillation06 = false;
            BoolCameraVentillation07 = false;
            BoolCameraVentillation08 = false;
            BoolCameraVentillation09 = false;
            BoolCameraVentillation10 = false;
            BoolCameraVentillation11 = false;


        }

        if (other.gameObject.tag == "Corps")
        {
            Debug.Log("Je ne touche plus un cadavre");
            Corps = false;
        }


        if (other.gameObject.tag == "Emergency")
        {
            Debug.Log("Je quitte boutonEmergency");
            Emergency = false;
        }

        if (other.gameObject.tag == "Son" && other.gameObject.name == "LaunchPadContact" && LaunchPadMusic == true)
        {
            Debug.Log("Je quitte Music Pad");
            LaunchPadMusic = false;
            SoundLaunchPad.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "LaboContact" && LaboMusic == true)
        {
            Debug.Log("Je quitte Music Labo");
            LaboMusic = false;
            SoundLabo.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "ReactorContact" && ReactorMusic == true)
        {
            Debug.Log("Jentre Music Reactor");
            ReactorMusic = false;
            SoundReactor.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "MedbayContact" && MedbayMusic == true)
        {
            Debug.Log("Jentre Music MedbayMusic");
            MedbayMusic = false;
            SoundMedbay.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "ComContact" && ComMusic == true)
        {
            Debug.Log("Jentre Music ComMusic");
            ComMusic = false;
            SoundCom.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "AdminContact" && AdminMusic == true)
        {
            Debug.Log("Jentre Music AdminMusic");
            AdminMusic = false;
            SoundAdmin.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "OfficeContact" && OfficeMusic == true)
        {
            Debug.Log("Jentre Music OfficeMusic");
            OfficeMusic = false;
            SoundOffice.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "GreenContact" && GreenMusic == true)
        {
            Debug.Log("Jentre Music GreenMusic");
            GreenMusic = false;
            SoundGreen.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "CafetariaContact" || other.gameObject.name == "Cafetaria2Contact" && CafetariaMusic == true)
        {
            Debug.Log("Jentre Music CafetariaMusic");
            CafetariaMusic = false;
            SoundCafetaria.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "StroageContact" && StorageMusic == true)
        {
            Debug.Log("Jentre Music StorageMusic");
            StorageMusic = false;
            SoundStorage.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "LockerContact" && LockerMusic == true)
        {
            Debug.Log("Jentre Music StorageMusic");
            LockerMusic = false;
            SoundLocker.SetActive(false);
        }
        if (other.gameObject.tag == "Son" && other.gameObject.name == "CouloirContact01" || other.gameObject.name == "CouloirContact02" || other.gameObject.name == "CouloirContact03" || other.gameObject.name == "CouloirContact04" || other.gameObject.name == "CouloirContact05" || other.gameObject.name == "CouloirContact06" && CouloirMusic == true)
        {
            Debug.Log("Jentre Music CafetariaMusic");
            CouloirMusic = false;
            SoundCouloir.SetActive(false);
        }

    }




}
