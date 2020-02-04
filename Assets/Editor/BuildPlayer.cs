using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuildPlayer
{
    public static void TestCallByBatch()
    {
        Debug.Log("TestCallByBatch Start");

        string[] args = Environment.GetCommandLineArgs();
        Debug.Log("CommandLineArgs");
        foreach (var arg in args)
            Debug.Log(arg);

        IDictionary vars = Environment.GetEnvironmentVariables();
        Debug.Log("EnvironmentVariables");
        foreach (var varKey in vars.Keys)
            Debug.Log(varKey + " " + vars[varKey]);

        Debug.Log("TestCallByBatch End");
    }
}
