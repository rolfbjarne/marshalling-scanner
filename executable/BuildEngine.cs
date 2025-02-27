// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Microsoft.Build.Framework;

public class BuildEngine : IBuildEngine, IBuildEngine2, IBuildEngine3, IBuildEngine4 {

    public int ColumnNumberOfTaskNode => 0;

    public bool ContinueOnError => throw new NotImplementedException ();

    public int LineNumberOfTaskNode => 0;

    public string ProjectFileOfTaskNode => string.Empty;

    public bool IsRunningMultipleNodes => throw new NotImplementedException ();

    public bool BuildProjectFile (string projectFileName, string [] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs)
    {
        throw new NotImplementedException ();
    }

    public void LogCustomEvent (CustomBuildEventArgs e)
    {
    }

    public void LogErrorEvent (BuildErrorEventArgs e)
    {
        Console.WriteLine (e.Message);
    }

    public void LogMessageEvent (BuildMessageEventArgs e)
    {
        Console.WriteLine (e.Message);
    }

    public void LogWarningEvent (BuildWarningEventArgs e)
    {
        Console.WriteLine (e);
    }

    public bool BuildProjectFile (string projectFileName, string [] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs, string toolsVersion)
    {
        throw new NotImplementedException ();
    }

    public bool BuildProjectFilesInParallel (string [] projectFileNames, string [] targetNames, System.Collections.IDictionary [] globalProperties, System.Collections.IDictionary [] targetOutputsPerProject, string [] toolsVersion, bool useResultsCache, bool unloadProjectsOnCompletion)
    {
        throw new NotImplementedException ();
    }

    public BuildEngineResult BuildProjectFilesInParallel (string [] projectFileNames, string [] targetNames, System.Collections.IDictionary [] globalProperties, System.Collections.Generic.IList<string> [] removeGlobalProperties, string [] toolsVersion, bool returnTargetOutputs)
    {
        throw new NotImplementedException ();
    }

    public void Reacquire ()
    {
        throw new NotImplementedException ();
    }

    public void Yield ()
    {
        throw new NotImplementedException ();
    }

    public object GetRegisteredTaskObject (object key, RegisteredTaskObjectLifetime lifetime)
    {
        throw new NotImplementedException ();
    }

    public void RegisterTaskObject (object key, object obj, RegisteredTaskObjectLifetime lifetime, bool allowEarlyCollection)
    {
        throw new NotImplementedException ();
    }

    public object UnregisterTaskObject (object key, RegisteredTaskObjectLifetime lifetime)
    {
        throw new NotImplementedException ();
    }
}
