using UnityEngine;
using Fusion;
using TMPro;
using System;
public class PlayerProperties : NetworkBehaviour
{
    [Networked, OnChangedRender(nameof(OnHPChanged))]

    public int _hpPlayer { get; set; } = 9999;
    public TextMeshPro hpText;

    public void OnHPChanged()
    {
        hpText.text = _hpPlayer.ToString()+"\ncon nice";
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("emi"))
        {
            _hpPlayer -= 10;
            if (_hpPlayer <= 0)
            {
                _hpPlayer = 0;
            }
            Debug.Log("va cham voi quai hehe: " + _hpPlayer);
        }
    }

    //làm cho text hiện luôn quay về phía camera
    private void Update()
    {
        if (hpText != null)
        {
            hpText.transform.LookAt(Camera.main.transform);
            hpText.transform.Rotate(0, 180, 0); // Đảo ngược hướng nhìn
        }
    }
}
