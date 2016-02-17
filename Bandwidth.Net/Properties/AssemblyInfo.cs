﻿using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Bandwidth.Net")]
[assembly: AssemblyDescription(".NET SDK for use with the Catapult API")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Bandwidth")]
[assembly: AssemblyProduct("Bandwidth.Net")]
[assembly: AssemblyCopyright("Copyright © Bandwidth 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion("2.13.0.0")]
[assembly: AssemblyFileVersion("2.13.0.0")]

#if DEBUG

[assembly: InternalsVisibleTo("Bandwidth.Net.Tests")]
#endif
