using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int orbs = 0;
    [SerializeField] private AudioSource _playerSounds;

    public int Orbs { get => orbs; set => orbs = value; }
    public AudioSource PlayerSounds  => _playerSounds;
}
