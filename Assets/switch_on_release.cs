using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switch_on_release : MonoBehaviour
{   
    public Animator anim;
    public float delay = 3;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Truck");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.enabled=false;
            StartCoroutine(LoadLevelAfterDelay(delay));
        }
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(3);
    }
    
}