using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update

    public static CameraShake Instance { get; private set; }
    [SerializeField] private CinemachineVirtualCamera cam;
    private float ShakeTimer;


    private void Awake()
    {
        Instance = this;
        cam = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMumtichennel = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMumtichennel.m_AmplitudeGain = intensity;
        ShakeTimer = time;



    }


    private void Update()
    {


        if (ShakeTimer > 0f)
        {
            ShakeTimer -= Time.deltaTime;
            Debug.Log(ShakeTimer.ToString());
        }

            
        if (ShakeTimer <= 0f) 
        {
            CinemachineBasicMultiChannelPerlin cinemachineBasicMumtichennel = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
            cinemachineBasicMumtichennel.m_AmplitudeGain = 0f;
        }
    }




}
