using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Slider slider;

    [SerializeField]
    Gradient gradient;

    [SerializeField]
    Image fill;

    public void setMaxHealth(int val)
    {
        slider.maxValue = val;
        slider.value = val;

        fill.color = gradient.Evaluate(1f);
    }
    public void setHealth(int val)
    {
        slider.value = val;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
