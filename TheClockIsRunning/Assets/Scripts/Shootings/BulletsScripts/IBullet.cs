using UnityEditor;
using UnityEngine;

public interface IBullet
{
    public float Damage { get; }

    public void DestroyBullet(); 
}
