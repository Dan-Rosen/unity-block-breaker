using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject game = GameObject.Find("Ball");
        Ball ball = game.GetComponent<Ball>();

        if (ball.hasStarted)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
