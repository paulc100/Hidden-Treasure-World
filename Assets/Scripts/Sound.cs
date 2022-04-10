using UnityEngine;

[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip Clip;

    [Range(0.0f, 1.0f)]
    public float Volume;
    [Range(0.1f, 3.0f)]
    public float Pitch;
    [Range(0.0f, 1.0f)]
    public float Time;
    [Range(0.0f, 3.0f)]
    public float Speed = 1;
    [Range(0.0f, 25.0f)]
    public float FadeinTime = 1;
    [Range(0.0f, 25.0f)]
    public float FadeoutTime = 1;

    public bool Fade;

    public bool Loop;

    [HideInInspector]
    public AudioSource Source;
}