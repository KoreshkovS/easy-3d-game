using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    [SerializeField] private AudioClip _collectSound;

    private Player _player;

    private void Start()
    {
        _player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            _player.Orbs += 1;
            _player.PlayerSounds.PlayOneShot(_collectSound);
            Destroy(gameObject);
        }
    }
}
