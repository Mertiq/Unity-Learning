using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Cube", menuName ="Cubes")]
public class Cube : ScriptableObject
{
    public new string name;
    
    public Color color;
    public Sprite sprite;

    public int health;
    public bool canMove;
    
}
