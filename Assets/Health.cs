using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearths;
    private int i = 0;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart; 


    void Update(){


        if(health > numOfHearths){
            health = numOfHearths;
        }

        for (i = 0; i < hearts.Length; i++)

        if (i < health){
            hearts[i].sprite = fullHeart;
        }
        else {
            hearts[i].sprite = emptyHeart;
        }

        if(i < numOfHearths){
            hearts[i].enabled = true;
        } else {
            hearts[i].enabled = false;
        }


    }
}
