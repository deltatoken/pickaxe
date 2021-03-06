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

using Pickaxe.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace Pickaxe.CodeDom.Visitor
{
    public partial class CodeDomGenerator : IAstVisitor
    {
        public void Visit(NodesBooleanExpression expression)
        {
            var left = VisitChild(expression.Left, new CodeDomArg() { Scope = _codeStack.Peek().Scope });
            var right = VisitChild(expression.Right, new CodeDomArg() { Scope = _codeStack.Peek().Scope });

            //strip .nodes
            var leftExpr = new CodeSnippetExpression(Regex.Replace(GenerateCodeFromExpression(left.CodeExpression), "\\.nodes", ""));
            _codeStack.Peek().CodeExpression = new CodeMethodInvokeExpression(leftExpr, "CssWhere", new CodeDirectionExpression(FieldDirection.Ref, leftExpr), right.CodeExpression);
        }
    }
}
