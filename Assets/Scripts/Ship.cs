using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float shipSpeed;
    private Vector3 playerStartPosition;
    public Vector3 playerEndPosition;
    public Vector3 shipEndPosition;
    public GameObject player;

    // Update is called once per frame
    void Start()
    {
        playerStartPosition = player.transform.position;
        StartCoroutine(MoveObject(transform.position));
        player.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed = 0;

        SoundManager.Instance.Play("Ocean");
    }

    IEnumerator MoveObject(Vector3 startPos)
    {
        float progress = 0.0f;
        float speed = shipSpeed;

        while (progress < 1.0f)
        {
            transform.position = Vector3.Lerp(startPos, shipEndPosition, progress);

            player.transform.position = Vector3.Lerp(playerStartPosition, playerEndPosition, progress);

            yield return new WaitForEndOfFrame();
            progress += Time.deltaTime * speed;
        }

        transform.position = shipEndPosition;
        player.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed = 6;
    }
}
