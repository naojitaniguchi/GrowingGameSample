using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyScriptable/Create Training")]
public class Training : ScriptableObject
{
    public string TrainingName;
    public int strength = 0;
    public int intelligence = 0;
    public int dignity = 0;
    public int moral = 0;
    public int magicalPower = 0;
    public int sensitivity = 0;
    public int charm = 0;
    public int courtesy = 0;
    public int art = 0;
    public int speaking = 0;
    public int feeling = 0;
}
