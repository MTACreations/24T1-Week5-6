using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 30;
    public Text timeText;

    public SceneLoader sceneLoader;

    public void Update()
    {
        time -= Time.deltaTime;
        Countdown(time);

        if (time < 0)
        {
            sceneLoader.GameOver();
        }
    }

    public void ChangeTime(int extraTime)
    {
        time = time + extraTime;
    }

    public void Countdown(float timeLeft)
    {
        timeLeft += 1;

        float minutesLeft = Mathf.FloorToInt(timeLeft / 60);
        float secondsLeft = Mathf.FloorToInt(timeLeft % 60);

        timeText.text = string.Format("{0:00} : {1:00}", minutesLeft, secondsLeft);
    }
}
