using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class LoginManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField PlayerName_InputName;

    #region Unity Methods
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion

    #region UI Callback Methodes
    public void ConnectAnonymously()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void ConnenctPhotonServer()
    {
        if(PlayerName_InputName != null)
        {
            PhotonNetwork.NickName = PlayerName_InputName.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }


    #endregion

    #region Phothon Callback Methods

    public override void OnConnected()
    {
        Debug.Log("Onconnected is called. �����۵�!");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server! ������̸� :" + PhotonNetwork.NickName);
        PhotonNetwork.LoadLevel("HomeScene");
    }

    #endregion
}
