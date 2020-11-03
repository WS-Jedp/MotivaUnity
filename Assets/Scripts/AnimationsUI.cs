using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationsUI : MonoBehaviour
{
    public GameObject menu;
    public GameObject help;
	private Animator anim;

    private void Start()
    {
        LeanTween.moveX(help, 0, 0.3f);
		anim = menu.GetComponent<Animator>();
    }

    public void closeMenu()
    {
        LeanTween.moveX(help, 0, 0.3f);
        LeanTween.moveY(menu, -100f, 0.6f);
    }

    public void showMenu()
    {
		anim.SetBool("Entry", true);
		this.gameObject.SetActive(false);
		//LeanTween.moveX(help, 42f, 0.3f);
        //LeanTween.moveY(menu, -23f, 0.6f);
    }
}
