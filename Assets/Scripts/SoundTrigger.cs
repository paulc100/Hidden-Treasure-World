using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public string playSound;
    public string stopSound;
    private bool status = true;

    private void OnTriggerEnter(Collider other)
    {
        if (status)
        {
            if (playSound.Length > 2)
            {
                SoundManager.Instance.Play(playSound);
            }
            if (stopSound.Length > 2)
            {
                SoundManager.Instance.Stop(stopSound);
            }
            status = false;
        }
        else
        {
            if (playSound.Length > 2)
            {
                SoundManager.Instance.Stop(playSound);
            }
            if (stopSound.Length > 2)
            {
                SoundManager.Instance.Play(stopSound);
            }
            status = true;
        }
    }
}

// Vector3(105.889992,2.44000006,-6.5)