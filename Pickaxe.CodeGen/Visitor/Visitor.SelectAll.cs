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

using Pickaxe.CodeDom.Semantic;
using Pickaxe.Runtime;
using Pickaxe.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickaxe.CodeDom.Visitor
{
    public partial class CodeDomGenerator : IAstVisitor
    {
        public void Visit(SelectAll all)
        {
            all.Parent.Parent.Children.Remove(all.Parent);

            var tableMatches = Scope.Current.FindAll();
            if(tableMatches.Length == 0) //only has a dynamic object and we can't tell the property names till runtime. Compile error.
                Errors.Add(new SelectNoColumnsFound(new Semantic.LineInfo(all.Line.Line, all.Line.CharacterPosition)));

            foreach (var match in tableMatches)
            {
                var tableReferance = new TableMemberReference {
                    Member = match.TableVariable.Variable,
                    RowReference = new TableVariableRowReference { Id = match.TableAlias },
                    Line = all.Line
                };

                var arg = new SelectArg();
                arg.Children.Add(tableReferance);
                all.Parent.Parent.Children.Add(arg);
            }
        }

    }
}
