using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScriptCS : MonoBehaviour
{
    public GameObject BrainError;
    public GameObject LoadingScreenTotallyReal;
    public double timer;

    void Update()
    {
        timer += 0.50;
        if (timer > 100)
        {
            BrainError.SetActive(true);
            LoadingScreenTotallyReal.SetActive(false);
        }
    }
}
