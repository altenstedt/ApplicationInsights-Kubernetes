﻿
namespace Microsoft.ApplicationInsights.Netcore.Kubernetes
{
    using System;
    using Microsoft.ApplicationInsights.Netcore.Kubernetes.Entity;
    internal static class OwnerReferenceExtensions
    {
        public static Type GetKind(this OwnerReference self)
        {
            switch (self.Kind)
            {
                case "ReplicaSet":
                    return typeof(ReplicaSet);
                default:
                    return null;
            }
        }
    }
}