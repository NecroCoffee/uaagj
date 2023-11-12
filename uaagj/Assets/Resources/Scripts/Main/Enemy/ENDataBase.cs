using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ‚±‚ê‚àV‚½‚Éì‚Á‚Ä‚İ‚é ENBase‚ğ“Ë‚Á‚ñ‚Ç‚¢‚Ä
/// </summary>
[CreateAssetMenu]
[SerializeField]
public class ENDataBase : ScriptableObject
{
    public List<ENBase> SEList = new List<ENBase>();
}
