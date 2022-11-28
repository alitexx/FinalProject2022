using UnityEngine;
using UnityEditor;
using System.IO;
using System;
public class manageSaveData : MonoBehaviour
{
    [SerializeField] TextAsset textFile;
    public void WriteString(int writeToFile)
    {
        //delete all text in the file
        File.WriteAllText(AssetDatabase.GetAssetPath(textFile), string.Empty);

        //open file in write mode
        StreamWriter writer = new StreamWriter(AssetDatabase.GetAssetPath(textFile), true);
        writer.Write(writeToFile);
        writer.Close();
    }
    public void ReadString()
    {
        string rawTXT = textFile.text;
        //string[] rawTXT = Regex.Split(textFile.text, "-");

        globalVariables.bestTimeLevel1 = Int32.Parse(rawTXT);

        Debug.Log(globalVariables.bestTimeLevel1);
        ////string path = Application.persistentDataPath + "/saveData.txt";
        //Debug.Log(path);
        ////Read the text from directly from the test.txt file
        //StreamReader reader = new StreamReader(path);
        //reader.Close();
    }
    private void Start()
    {
        globalVariables.localBestTimeLevel1 = globalVariables.timer;
        ReadString();
        if (globalVariables.localBestTimeLevel1 > globalVariables.bestTimeLevel1)
        {
            WriteString((int)globalVariables.localBestTimeLevel1);
        }
    }
}
