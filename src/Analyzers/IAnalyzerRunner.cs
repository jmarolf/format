﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.CodeAnalysis.Tools.Analyzers
{
    interface IAnalyzerRunner
    {
        Task<CodeAnalysisResult> RunCodeAnalysisAsync(
            Solution solution,
            ImmutableArray<DiagnosticAnalyzer> analyzers,
            ImmutableArray<DocumentId> formattableDocuments,
            ILogger logger,
            CancellationToken cancellationToken);
    }
}