using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowGameManager : MonoBehaviour
{
    public Training[] trainings;
    public enum TrainingType
    {
        LECTURE_REIHOU,     // 0
        LECTURE_MAHOUGAKU,  // 1
        LECTURE_BUNGAKU,    // 2
        LECTURE_BUYOU,      // 3
        LECTURE_KAIGA,      // 4
        LECTURE_GOSINJUTU,  // 5
        WORK_DAIHITSU,      // 6
        WORK_KAJI,          // 7
        WORK_NOUJOU,        // 8
        WORK_JINJA,         // 9
        WORK_KAIGA,         // 10
        WORK_YADOYA,        // 11
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
