using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BPM : MonoBehaviour {
    Text _text;
    public BPeerM _bPeerM;
	// Use this for initialization
	void Start () {
        _text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        _text.text = "BPM: " + _bPeerM._bpm.ToString();
	}
}
