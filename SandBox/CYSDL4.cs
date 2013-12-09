//  --------------------------------------------------------------------------------------------------------------------
// <copyright file="CYSDL4.cs" company="Cyrille DUPUYDAUBY">
//   Copyright 2013 Cyrille DUPUYDAUBY
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//  --------------------------------------------------------------------------------------------------------------------
namespace SandBox
{
    using System;
    using System.Threading;

    /// <summary>
    /// Can you spot the deadlock, episode 4.
    /// </summary>
    public class CYSDL4
    {
        /// <summary>
        /// Entry point for the test.
        /// </summary>
        public void Entry()
        {
            var workerThread = new Thread(Worker);
            workerThread.Start();

            // wait for the thread to start
            workerThread.Join();
        }

        /// <summary>
        /// Runner function for the thread.
        /// </summary>
        private static void Worker()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Console.Write("Blah ");
            }
        }
    }
}