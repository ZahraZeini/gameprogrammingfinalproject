using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeText : MonoBehaviour
{
    [SerializeField] private string volumeName;
    [SerializeField] private string textIntro; 
    private TMP_Text txt;

    private void Awake()
    {
        txt = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        if (txt != null) 
            UpdateVolume();
    }
    private void UpdateVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat(volumeName) * 100;
        txt.text = textIntro + volumeValue.ToString();
    }
}
