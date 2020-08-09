﻿/////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved
// Written by Forge Design Automation team for Inventor
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////

namespace WebApplication.Definitions
{
    // Strongly typed classes for settings defined in appsettings.json to be deserialized to

    public class AppBundleZipPaths
    {
        public string EmptyExe { get; set; }
        public string CreateSVF { get; set; }
        public string CreateThumbnail { get; set; }
        public string ExtractParameters { get; set; }
        public string UpdateParameters { get; set; }
        public string CreateSAT { get; set; }
        public string CreateRFA { get; set; }
        public string CreateBOM { get; set; }
        public string ExportDrawing { get; set; }
    }

    public class DefaultProjectsConfiguration
    {
        public DefaultProjectConfiguration[] Projects { get; set; }
    }

    public class DefaultProjectConfiguration : ProjectInfo
    {
        public string Url { get; set; }
    }

    public class InviteOnlyModeConfiguration
    {
        public bool Enabled { get; set; }
        public string[] Domains { get; set; }
        public string[] Addresses { get; set; }
    }
}
