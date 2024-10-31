using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMaterialController : MonoBehaviour
{
    public Renderer [] renderers; // Arabanın Renderer bileşeni (Materyal için)
    public Button redButton;     // Kırmızı buton
    public Button blueButton;    // Mavi buton
    public Button greenButton;   // Yeşil buton
    public Button yellowButton;  // Sarı buton

    public Material redMaterial;     // Kırmızı materyal
    public Material blueMaterial;    // Mavi materyal
    public Material greenMaterial;   // Yeşil materyal
    public Material yellowMaterial;  // Sarı materyal
    public Material whiteMaterial;  // Sarı materyal

    public Material currentMat;

    // Başlangıçta butonlara tıklama olaylarını ekliyoruz
    private void Awake()
    {
        currentMat = whiteMaterial; // başlangıç materyali // diğer kodlarda erişebilmek için.
    }
    void Start()
    {
        // Buton tıklamaları için olay dinleyicileri ekliyoruz
        redButton.onClick.AddListener(() => ChangeCarMaterial(redMaterial));    // Kırmızı materyal
        blueButton.onClick.AddListener(() => ChangeCarMaterial(blueMaterial));  // Mavi materyal
        greenButton.onClick.AddListener(() => ChangeCarMaterial(greenMaterial)); // Yeşil materyal
        yellowButton.onClick.AddListener(() => ChangeCarMaterial(yellowMaterial)); // Sarı materyal
    }

    // Arabanın materyalini değiştiren fonksiyon
    void ChangeCarMaterial(Material newMaterial)
    {
        foreach (Renderer renderer in renderers)
        {
            renderer.material = newMaterial;
            currentMat = newMaterial; // diğer kodlarda erişebilmek için.
        }
        
        //Debug.Log(currentMat);
    }
}
