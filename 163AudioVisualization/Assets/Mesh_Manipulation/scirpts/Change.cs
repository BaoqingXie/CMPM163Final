using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Material VertexDisplacementMaterial;
    public int _bandForNoiseDensity = 5;
    public int _bandForColorR = 2;
    public int _bandForColorG = 3;
    public int _bandForColorB = 4;
    public int _bandForSmoothness = 7;
    public float points = 15;
    public float totalPoints;
    public Color _color = new Color(0, 0, 0);
    public Color _colorb = new Color(0, 0, 0);
    public Vector3 density = new Vector3(0,0,0);
    public float smoothness = 0;
    
    public float _startScale, _scaleMultiplier, _scaleMultiplierColor, _startScaleColor;


    // Start is called before the first frame update
    void Start()
    {
        VertexDisplacementMaterial.SetFloat("Vector1_99762302", points/totalPoints);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)){
            points += 5;
            VertexDisplacementMaterial.SetFloat("Vector1_99762302", points/totalPoints);
        }

        if(Input.GetKeyDown(KeyCode.A)){
            _color.r +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.S)){
            _color.g +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.D)){
            _color.b +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            _colorb.r +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }

        if(Input.GetKeyDown(KeyCode.W)){
            _colorb.g +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            _colorb.b +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }


        density.x= (GetAudioData._freqBand[_bandForNoiseDensity] *_scaleMultiplier) +_startScale;
        smoothness = (GetAudioData._freqBand[_bandForSmoothness] *_scaleMultiplier) +_startScale;

        _color.r = (GetAudioData._freqBand[_bandForColorR] *_scaleMultiplierColor) +_startScaleColor;
        _color.g = (GetAudioData._freqBand[_bandForColorG] *_scaleMultiplierColor) +_startScaleColor;
        _color.b = (GetAudioData._freqBand[_bandForColorB] *_scaleMultiplierColor) +_startScaleColor;

        _colorb.r = (GetAudioData._freqBand[_bandForColorB] *_scaleMultiplierColor) +_startScaleColor;
        _colorb.g = (GetAudioData._freqBand[_bandForColorG] *_scaleMultiplierColor) +_startScaleColor;
        _colorb.b = (GetAudioData._freqBand[_bandForColorR] *_scaleMultiplierColor) +_startScaleColor;

        VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
         VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);

         if(smoothness<0.8){
            VertexDisplacementMaterial.SetFloat("Vector1_78FED68B", smoothness);
         }else{
            VertexDisplacementMaterial.SetFloat("Vector1_78FED68B", 0.8f);
         }

        VertexDisplacementMaterial.SetFloat("Vector1_CE6608C1", density.x);

        Debug.Log(smoothness);
             //transform.localScale = new Vector3(transform.localScale.x, (GetAudioData._bandBuffer[_band] *_scaleMultiplier) +_startScale, transform.localScale.z);
             //Color _color = new Color(10, 0, 0);
             //_material.SetColor("_EmissionColor", _color);

    }
}
