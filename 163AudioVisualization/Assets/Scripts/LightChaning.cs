using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChaning : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLight;
    public Color _color = new Color(0, 0, 0);
    public Color _colorb = new Color(0, 0, 0);
        public float _startScale, _scaleMultiplier, _scaleMultiplierColor, _startScaleColor;
            public int _bandForColorR = 2;
    public int _bandForColorG = 3;
    public int _bandForColorB = 4;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        _color.r = (GetAudioData._freqBand[_bandForColorR] *_scaleMultiplierColor) +_startScaleColor;
        _color.g = (GetAudioData._freqBand[_bandForColorG] *_scaleMultiplierColor) +_startScaleColor;
        _color.b = (GetAudioData._freqBand[_bandForColorB] *_scaleMultiplierColor) +_startScaleColor;

        _colorb.r = (GetAudioData._freqBand[_bandForColorB] *_scaleMultiplierColor) +_startScaleColor;
        _colorb.g = (GetAudioData._freqBand[_bandForColorG] *_scaleMultiplierColor) +_startScaleColor;
        _colorb.b = (GetAudioData._freqBand[_bandForColorR] *_scaleMultiplierColor) +_startScaleColor;
        myLight.color = _color;
    }
}
