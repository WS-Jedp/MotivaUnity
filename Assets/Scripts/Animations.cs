using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animations : MonoBehaviour
{

    public GameObject menu;
    public GameObject help;

    private void Start()
    {
        help.GetComponent<Animator>().SetBool("isShowMenu", false);
    }

    public void showMenu()
    {
        menu.GetComponent<Animator>().SetBool("isShowMenu", true);
    }
}
