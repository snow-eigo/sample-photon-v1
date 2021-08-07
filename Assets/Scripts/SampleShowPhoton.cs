using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleShowPhoton : MonoBehaviour
{
    public Text showPhotonText;
    
    
    private void Start()
    {
        showPhotonText.text = $"Photon App ID: {PhotonNetwork.PhotonServerSettings.AppID}";
    }
}
