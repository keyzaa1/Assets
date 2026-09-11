using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("OutsideScene");
    }
}