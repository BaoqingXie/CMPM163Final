using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightControl : MonoBehaviour
{
                public Light myLight1;
    public Color _color = new Color(0, 0, 0);
            public float _startScale, _scaleMultiplier, _scaleMultiplierColor, _startScaleColor;
            public int _bandForAngle= 2;
            public float angle = 0;

    void Start()
    {
         myLight1 = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = (GetAudioData._freqBand[_bandForAngle] *_scaleMultiplierColor) +_startScaleColor;

        myLight1.spotAngle = angle;
    }
}
