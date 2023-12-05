using UnityEngine;
using UnityEngine.SceneManagement;

public class Loser : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(3);
    }
}
