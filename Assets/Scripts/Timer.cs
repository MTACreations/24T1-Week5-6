using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 30;
    public SceneLoader sceneLoader;

    public void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            sceneLoader.GameOver();
        }
    }

    public void AddTime(int extraTime)
    {
        time = time + extraTime;
    }

    public void LoseTime(int penaltyTime)
    {
        time = time - penaltyTime;
    }
}
