﻿// <copyright file="Program.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace PiStellwerkLoadGenerator
{
    /// <summary>
    /// A tool that tries to simulate a "realistic user" by making requests to the PiStellwerk-server.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for the console application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var options = Options.GetOptionsFromArgs(args);

            var clientSimulator = new ClientSimulator(options);
            clientSimulator.Start();

            await Task.Delay(options.Time * 1000);

            clientSimulator.Stop();

            var results = clientSimulator.GetStatistics();

            foreach (var keyValuePair in results.ToImmutableSortedDictionary())
            {
                Console.WriteLine($"{keyValuePair.Key / 10d}ms : {keyValuePair.Value} times");
            }
        }
    }
}
