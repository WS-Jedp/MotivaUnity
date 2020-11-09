using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



[Serializable]
class MissionInformation
{
    public string[] missions;
    public string[] messages;
}

public class InteractionMissions : MonoBehaviour
{
    public Text msgTxt;
    public Text currentObjective;
    private MissionInformation missions;
    private int currentMission;

    // Start is called before the first frame update
    void Start()
    {
        currentMission = PlayerPrefs.GetInt("currMission", 0);
        string json = File.ReadAllText(Application.dataPath + "/Scripts/missions.json");
        missions = JsonUtility.FromJson<MissionInformation>(json);

        currentObjective.text = missions.missions[currentMission];
    }

    public void showMissionMessage()
    {
        msgTxt.text = missions.messages[currentMission];
    }

    public void nextMission()
    {
        PlayerPrefs.SetInt("currMission", currentMission + 1);
        currentMission = PlayerPrefs.GetInt("currMission", 0);
    }
}
