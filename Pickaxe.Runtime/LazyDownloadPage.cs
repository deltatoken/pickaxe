﻿/* Copyright 2015 Brock Reeve
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Pickaxe.Runtime.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pickaxe.Runtime
{
    public abstract class LazyDownloadPage : DownloadPage
    {
        private ThreadedDownloadTable<DownloadPage> _parent;
        private DownloadPage _inner;
        
        protected LazyDownloadPage(ThreadedDownloadTable<DownloadPage> parent)
        {
            _parent = parent;
        }

        protected string CssSelector { get; set; }

        protected DownloadPage Inner
        {
            get
            {
                _parent.Process();
                if (_inner == null)
                    _inner = _parent.GetResult();

                return _inner;
            }
            set
            {
                _inner = null;
            }
        }

        protected abstract void ApplyCssSelector(IEnumerable<HtmlElement> nodes);

        public override string url
        {
            get
            {
                return Inner.url;
            }
        }

        public override DownloadedNodes nodes
        {
            get
            {
                var nodes = Inner.nodes;
                if(CssSelector != null)
                        ApplyCssSelector(nodes);

                return Inner.nodes;
            }
        }

        public override DateTime? date
        {
            get
            {
                return Inner.date;
            }
        }

        public override int? size
        {
            get
            {
                return Inner.size;
            }
        }

    }
}
