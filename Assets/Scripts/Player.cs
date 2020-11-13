using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
    public int stress = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calcParameter( Training training)
    {
        if (training.stressMax >= 0)
        {
            stress += 10;
            if (stress > strength)
            {
                return;
            }
        }

        strength += Random.Range(training.strengthMin, training.strengthMax);
        intelligence += Random.Range(training.intelligenceMin, training.intelligenceMax);
        dignity += Random.Range(training.dignityMin, training.dignityMax);
        moral += Random.Range(training.moralMin, training.moralMax);
        magicalPower += Random.Range(training.magicalPowerMin, training.magicalPowerMax);
        sensitivity += Random.Range(training.sensitivityMin, training.sensitivityMax);
        charm += Random.Range(training.charmMin, training.charmMax);
        courtesy += Random.Range(training.courtesyMin, training.courtesyMax);
        art += Random.Range(training.artMin, training.artMax);
        speaking += Random.Range(training.speakingMin, training.speakingMax);
        feeling += Random.Range(training.feelingMin, training.feelingMax);
        stress += Random.Range(training.stressMin, training.stressMax);
    }
}
