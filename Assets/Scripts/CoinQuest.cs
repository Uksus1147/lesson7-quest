using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoinQuest : MonoBehaviour
{
    public GameObject ButtoStart;
    public float CheckId = 1;
    public GameObject Winner;
    public void Start()
    {
        Time.timeScale = 0;
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        ButtoStart.SetActive(false);
    }
    public void Quest(int Quetid)
    {
        if(Quetid == CheckId)
        {
            CheckId++;
        }
        else if(Quetid != CheckId)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void Update()
    {
        if(CheckId == 5)
        {
            Winner.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
