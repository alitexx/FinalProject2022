using UnityEngine;
using UnityEditor;
using System.IO;
using System;
public class manageSaveData : MonoBehaviour
{
    public static void WriteString(int writeToFile)
    {
        //delete all text in the file
        File.WriteAllText("Assets/saveData.txt", string.Empty);

        //open file in write mode
        StreamWriter writer = new StreamWriter("Assets/saveData.txt", true);
        writer.Write(writeToFile);
        writer.Close();
        Debug.Log("Assets/saveData.txt");
    }
    public static void ReadString()
    {
        StreamReader reader = new StreamReader("Assets/saveData.txt", true);
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
