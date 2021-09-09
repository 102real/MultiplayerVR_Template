using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomManager : MonoBehaviourPunCallbacks
{
    #region Unity Methods
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion

    #region UI Callback Methodes

    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    #endregion

    #region Phothon Callback Methods

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log(message);
        CreateAndJoinRoom();
    }

    

    public override void OnCreatedRoom()
    {
        Debug.Log("�� �����Ϸ�" + PhotonNetwork.CurrentRoom.Name);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("�����÷��̾� :"+PhotonNetwork.NickName + "������ :" + PhotonNetwork.CurrentRoom.Name + "�÷����ο� :" +PhotonNetwork.CurrentRoom.PlayerCount);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName+"�� �����߽��ϴ�" +"�÷��̾�ī��Ʈ" + PhotonNetwork.CurrentRoom.PlayerCount);
    }

    #endregion

    #region Private Methods
    private void CreateAndJoinRoom()
    {
        string randomRommName = "Room_" + Random.Range(0, 10000);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;

        PhotonNetwork.CreateRoom(randomRommName, roomOptions);
    }
    #endregion
}
