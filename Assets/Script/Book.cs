using UnityEngine;
using UnityEngine.UI;

public class Book : Interactable
{
    public Image pageImageUI;// UI'deki Image bile�eni

    [Header("Sayfa Ayarlar�")]
    public Sprite[] pageSprites; // Sayfa g�rselleri (PNG)
    

    [Header("Ses")]
    public AudioClip pageFlipSound;
    private AudioSource audioSource;

    private int currentPage = 0;
    private bool isReading = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public override void Interact()
    {
        if (!isReading)
        {
            StartReading();
        }
        else
        {
            ShowNextPage();
        }
    }

    void StartReading()
    {
        isReading = true;
        currentPage = 0;
        pageImageUI.gameObject.SetActive(true);
        ShowPage();
    }

    void ShowNextPage()
    {
        if (pageFlipSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(pageFlipSound);
        }

        currentPage++;

        if (currentPage >= pageSprites.Length)
        {
            EndReading();
        }
        else
        {
            ShowPage();
        }
    }

    void ShowPage()
    {
        pageImageUI.sprite = pageSprites[currentPage];
        pageImageUI.SetNativeSize(); // �ste�e ba�l�: orijinal boyut
    }

    void EndReading()
    {
        isReading = false;
        pageImageUI.gameObject.SetActive(false);
    }
}
