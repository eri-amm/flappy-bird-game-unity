using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderConfirm : MonoBehaviour
{
    [SerializeField] Slider ostSlider;
    [SerializeField] Slider pointsSlider;

    public void confirm()
    {
        PlayerPrefs.SetFloat("MusicVol", ostSlider.value);
        PlayerPrefs.SetFloat("PointsVol", pointsSlider.value);
    }
}
