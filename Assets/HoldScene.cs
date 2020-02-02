using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoldScene : MonoBehaviour
{
     public float delay = 40;
     public string NewLevel= "OpeningScene";
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(NewLevel);
         Debug.Log("OpeningScene loaded");
     }
 }
