﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging;

namespace IntegrationTests;

/// <summary>
/// A logger provider that stores logs in an <see cref="LoggerLogStore"/>.
/// </summary>
internal class StoredLogsLoggerProvider(LoggerLogStore logStore) : ILoggerProvider
{
    private readonly LoggerExternalScopeProvider _scopeProvider = new();

    public ILogger CreateLogger(string categoryName)
    {
        return new StoredLogsLogger(logStore, _scopeProvider, categoryName);
    }

    public void Dispose()
    {
    }
}