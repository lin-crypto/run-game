using UnityEngine;
using System.Collections;

public class TimeDestroyer : MonoBehaviour
{
    // Use this for initialization
    void Update()
    {
        Invoke("DestroyObject", LifeTime);
    }


    void DestroyObject()
    {
        if (GameManager.Instance.GameState == GameState.Playing)
            Destroy(gameObject);
    }


    public float LifeTime = 60f;
    public Transform Character;
}
