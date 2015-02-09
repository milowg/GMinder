/// Copyright (c) 2009, Greg Todd
/// All rights reserved.
///
/// Redistribution and use in source and binary forms, with or without modification,
/// are permitted provided that the following conditions are met:
/// 
/// * Redistributions of source code must retain the above copyright notice,
///   this list of conditions and the following disclaimer.
///   
/// * Redistributions in binary form must reproduce the above copyright notice,
///   this list of conditions and the following disclaimer in the documentation
///   and/or other materials provided with the distribution.
///   
/// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
/// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
/// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
/// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
/// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
/// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
/// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
/// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
/// OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
/// OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using Google.GData.Client;

namespace ReflectiveCode.GMinder
{
    public class DownloadHelper<TEntry> where TEntry : AtomEntry
    {
        private readonly Service _Service;
        private readonly Queue<TEntry> _Queue = new Queue<TEntry>();

        public DownloadHelper(Service service)
        {
            _Service = service;
        }

        public void Download(FeedQuery query)
        {
            AtomFeed feed = _Service.Query(query);

            while (feed != null && feed.Entries.Count > 0)
            {
                foreach (TEntry entry in feed.Entries)
                    _Queue.Enqueue(entry);

                if (feed.NextChunk == null)
                    break;

                query.Uri = new Uri(feed.NextChunk);
                feed = feed.Service.Query(query);
            }
        }

        public IEnumerable<TEntry> Results
        {
            get
            {
                while (_Queue.Count > 0)
                    yield return _Queue.Dequeue();
            }
        }
    }
}
