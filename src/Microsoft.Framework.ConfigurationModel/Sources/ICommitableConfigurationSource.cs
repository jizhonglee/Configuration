// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Net.Runtime;

namespace Microsoft.Framework.ConfigurationModel
{
    //[AssemblyNeutral]
    public interface ICommitableConfigurationSource
    {
        void Commit();
    }
}