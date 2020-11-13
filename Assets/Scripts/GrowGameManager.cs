using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrowGameManager : MonoBehaviour
{
    public Training[] trainings;
    public int[] schedule;
    public int scheduleNum;
    public GameObject scheduleText;
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
        WORK_YADOYA,        // 10
    }


    // Start is called before the first frame update
    void Start()
    {
        scheduleNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Schedule( int type)
    {
        Debug.Log(trainings[type].TrainingName);

        scheduleText.GetComponent<Text>().text += "\n" + trainings[type].TrainingName;

        if (scheduleNum < schedule.Length)
        {
            schedule[scheduleNum] = type;
            scheduleNum++;
        }
    }
}
