using UnityEngine;
using UnityEditor;
using System.IO;
using System;
public class manageSaveData : MonoBehaviour
{
    public static void WriteString(int writeToFile)
    {
        //delete all text in the file
        File.WriteAllText(Application.streamingAssetsPath + "/saveData.txt", string.Empty);

        //open file in write mode
        File.WriteAllText(Application.streamingAssetsPath + "/saveData.txt", writeToFile.ToString());
        //StreamWriter writer = new StreamWriter(Application.streamingAssetsPath + "/saveData.txt", true);
        //StreamWriter writer = new StreamWriter("Assets/saveData.txt", true);
        //writer.Write(writeToFile);
        //writer.Close();
        Debug.Log(writeToFile + " has been saved!");
    }
    public static void ReadString()
    {
        StreamReader reader = new StreamReader(Application.streamingAssetsPath + "/saveData.txt", true);
        //StreamReader reader = new StreamReader("Assets/saveData.txt", true);
        string rawTXT = reader.ReadLine();
        reader.Close();
        // if we have level 2
        //string[] rawTXT = Regex.Split(textFile.text, "-");
        globalVariables.bestTimeLevel1 = Int32.Parse(rawTXT);
        Debug.Log("Reading from file...");
        
    }
    private void Start()
    {
        ReadString();
    }
}
