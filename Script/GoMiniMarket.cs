using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMiniMarket : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("MiniMarket");
    }
}