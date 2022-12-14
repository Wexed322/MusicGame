using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PalabrasSugeridas", menuName = "ScriptableObjects/PalabrasSugeridas", order = 1)]
public class PalabrasSugeridas : ScriptableObject
{
    public int IDNivel;
    public List<string> palabras;
}
