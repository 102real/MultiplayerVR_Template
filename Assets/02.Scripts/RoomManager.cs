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
        Debug.Log("방 생성완료" + PhotonNetwork.CurrentRoom.Name);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("로컬플레이어 :"+PhotonNetwork.NickName + "참여방 :" + PhotonNetwork.CurrentRoom.Name + "플레이인원 :" +PhotonNetwork.CurrentRoom.PlayerCount);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName+"가 참여했습니다" +"플레이어카운트" + PhotonNetwork.CurrentRoom.PlayerCount);
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
