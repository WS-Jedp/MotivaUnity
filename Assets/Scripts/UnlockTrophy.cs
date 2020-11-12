using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockTrophy : MonoBehaviour
{
    public GameObject[] Medals;

    // The current mission of the application
    private int currentMission = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= currentMission; i++)
        {
            Medals[i].GetComponent<Animator>().SetBool("firstMission", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
