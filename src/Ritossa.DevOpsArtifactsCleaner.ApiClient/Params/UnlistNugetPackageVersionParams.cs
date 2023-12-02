﻿namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class UnlistNugetPackageVersionParams : BaseParams
{
    public class Package
    {
        public string IdOrName { get; set; }
        public string Version { get; set; }
    }

    public List<Package> Packages { get; set; } = new();
}