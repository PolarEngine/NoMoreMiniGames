using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using Photon.Pun;
using UnityEngine;
using GorillaNetworking;
using HarmonyLib;
using System.Reflection;
using Photon.Realtime;

namespace NoMoreMiniGames
{
    [BepInPlugin("com.polar.NoMoreMiniGames" , "NoMoreMiniGames" , "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        public void Start()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
            GameObject.Find("Global/Photon Manager").AddComponent<PolarNetworkManager>();
        }
    }

    public class PolarNetworkManager : MonoBehaviourPunCallbacks
    {
        public override void OnJoinedRoom()
        {
            base.OnJoinedRoom();
            foreach(Photon.Realtime.Player target in PhotonNetwork.PlayerListOthers)
            {
                if (target.NickName.Contains("JMANCURLY"))
                {
                    GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
                }

                if (target.NickName.Contains("MINI"))
                {
                    GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
                }

                if (target.NickName.Contains("MINIGAMES"))
                {
                    GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
                }

                if (target.NickName.Contains("KID"))
                {
                    GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
                }
            }
        }

        public override void OnPlayerEnteredRoom(Player target)
        {
            base.OnPlayerEnteredRoom(target);
            if (target.NickName.Contains("JMANCURLY"))
            {
                GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
            }

            if (target.NickName.Contains("MINI"))
            {
                GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
            }

            if (target.NickName.Contains("MINIGAMES"))
            {
                GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
            }

            if (target.NickName.Contains("KID"))
            {
                GorillaPlayerScoreboardLine.MutePlayer(target.UserId, target.NickName, 1);
            }
        }
    }
}
