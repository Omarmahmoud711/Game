using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score : MonoBehaviour
{
public Transform player;
public TextMeshProUGUI Score;

    // Update is called once per frame
    public void Update()
    {
       Score.text =((player.position.z + 350 )/7).ToString("0");
       if(((player.position.z+350)/7).ToString()=="100")
        {
            
        Score.enabled=false;

       }
    }
}
