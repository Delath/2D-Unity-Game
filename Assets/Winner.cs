using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(2);
    }
}
