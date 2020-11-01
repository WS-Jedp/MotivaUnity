using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

[Serializable]
public class OptionsMessages
{
    public int currMsg = 0;
    public string[] files = { "tips.json", "motivation.json" };
    public int currTypeMsg = 0;
}

[Serializable]
public class Messages
{
    public string[] data;
}

public class InteractionsChat : MonoBehaviour
{
    OptionsMessages currentsMsgs = new OptionsMessages();
    public Text msgTxt;

    // Get a number to select a file
    private static int setCurrentFile()
    {
        System.Random number = new System.Random();
        return number.Next(0, 2);
    }

    // Select a message from the json file
    private static string setCurrentMessage(Messages file)
    {
        System.Random randomMsg = new System.Random();
        string currMsg = file.data[randomMsg.Next(0, 2)];
        return currMsg;
    }

    // Start is called before the first frame update
    void Start()
    {
        string json = File.ReadAllText(Application.dataPath + "/Scripts/" + currentsMsgs.files[setCurrentFile()]);
        Messages msgs = JsonUtility.FromJson<Messages>(json);
        msgTxt.text = setCurrentMessage(msgs);
    }   

    public void showTip()
    {
        string json = File.ReadAllText(Application.dataPath + "/Scripts/" + currentsMsgs.files[0]);
        Messages msgs = JsonUtility.FromJson<Messages>(json);
        msgTxt.text = setCurrentMessage(msgs);
    }

    public void showMotivation()
    {
        string json = File.ReadAllText(Application.dataPath + "/Scripts/" + currentsMsgs.files[1]);
        Messages msgs = JsonUtility.FromJson<Messages>(json);
        msgTxt.text = setCurrentMessage(msgs);
    }
}
