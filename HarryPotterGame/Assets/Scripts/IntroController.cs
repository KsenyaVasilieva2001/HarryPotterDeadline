using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    public GameObject startLevelScreen;
    void Start()
    {
        startLevelScreen = GameObject.Find("LevelStart");
        StartCoroutine(WaitAndPrintLevel());
    }
    private IEnumerator WaitAndPrintLevel()
    {
        startLevelScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        startLevelScreen.SetActive(false);
    }
}
