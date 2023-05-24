using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
 
 public GameManager gm;
 public void OnTriggerEnter(){

gm.LevelComplete();

 }
}
