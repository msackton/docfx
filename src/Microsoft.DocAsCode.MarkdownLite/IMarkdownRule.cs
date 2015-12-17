﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode.MarkdownLite
{
    public interface IMarkdownRule
    {
        string Name { get; }
        IMarkdownToken TryMatch(IMarkdownParser engine, ref string source);
    }
}