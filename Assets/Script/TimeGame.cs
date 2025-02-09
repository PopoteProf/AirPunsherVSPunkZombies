using System;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    [Range(0, 1)]
    public float TimeScale;
    private void Update()
    {
        Time.timeScale = TimeScale;
    }
}
