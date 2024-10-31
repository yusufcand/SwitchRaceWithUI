using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DikenTuzagi_SC : MonoBehaviour
{
    [SerializeField] private CarMaterialController carMaterialController;
    [SerializeField] GameObject gameOverPanel;
    void Start()
    {
        carMaterialController = GameObject.FindWithTag("Player").GetComponent<CarMaterialController>();
    }

    private void OnTriggerStay2D(Collider2D collision) // k�rm�z� ara�, hareket tuza��ndan ge�er
    {
        if (carMaterialController.currentMat.name != "GreenMaterial")
        {
            Destroy(collision.gameObject);
            // animasyon koyulacaksa bekleme kodu yaz�labilir.
            gameOverPanel.SetActive(true);
        }
        else if (carMaterialController.currentMat.name == "GreenMaterial")
        {
            // hi�bir �ey olmayacak.
        }
    }
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
