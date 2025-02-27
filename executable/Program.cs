// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using MonoTargetsTasks;

internal sealed class Program {
    private static int Main (string[] arguments)
    {
        var inputAssemblies = new List<string> ();

        // bool verbose = false;
        foreach (var arg in arguments) {
            // if (arg == "-v") {
            //     verbose = true;
            //     continue;
            // }
            if (File.Exists (arg)) {
                inputAssemblies.Add (arg);
            } else if (Directory.Exists (arg)) {
                inputAssemblies.AddRange (Directory.GetFiles (arg, "*.dll"));
            } else {
                Console.Error.WriteLine ($"Unknown argument, not a file nor a folder: {arg}");
                return 2;
            }
        }

        var t = new MarshalingPInvokeScanner ();
        t.BuildEngine = new BuildEngine ();
        t.Assemblies = inputAssemblies.OrderBy (v => v).ToArray ();
        // t.Verbose = verbose;
        var rv = t.Execute ();

        if (t?.IncompatibleAssemblies?.Any () == true) {
            Console.Error.WriteLine ($"❌ Failed, because some assemblies are incompatible");
            return 1;
        }

        return rv ? 0 : 1;
    }
}
