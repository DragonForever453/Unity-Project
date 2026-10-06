using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finishPanel;
    private void OnTriggerEnter(Collider other)
    {
        finishPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
