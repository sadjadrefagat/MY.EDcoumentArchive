using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;

namespace MY
{
    sealed public class LambdaExpressionVisitor : ExpressionVisitor
    {
        public LambdaExpressionVisitor(string parameterName)
        {
            ParameterName = parameterName;
            _values = new Dictionary<string, object>();
        }

        public string ParameterName { get; }

        private string _visitString = "";
        public string VisitString
        {
            get { return _visitString; }
        }

        private Dictionary<string, object> _values;
        public Dictionary<string, object> Values
        {
            get { return _values; }
        }

        private string VisitBinaryExpression(Expression node, string Operator)
        {
            var logBinExpr = (BinaryExpression)node;

            var leftVisitor = new LambdaExpressionVisitor(ParameterName);
            leftVisitor.Visit(logBinExpr.Left);

            var rightVisitor = new LambdaExpressionVisitor(ParameterName);
            rightVisitor.Visit(logBinExpr.Right);

            return $"({leftVisitor.VisitString} {Operator} {rightVisitor.VisitString})";
        }

        public override Expression Visit(Expression node)
        {
            if (node != null)
            {
                switch (node.NodeType)
                {
                    case ExpressionType.Add:
                        _visitString = VisitBinaryExpression(node, "+");
                        break;
                    case ExpressionType.AddChecked:
                        break;
                    case ExpressionType.And:
                        break;
                    case ExpressionType.AndAlso:
                        _visitString = VisitBinaryExpression(node, "AND");
                        break;
                    case ExpressionType.ArrayLength:
                        break;
                    case ExpressionType.ArrayIndex:
                        break;
                    case ExpressionType.Call:
                        {
                            var callExpre = node as MethodCallExpression;
                            switch (callExpre.Method.Name)
                            {
                                case "IsDBNull":
                                    {
                                        var visitor = new LambdaExpressionVisitor(ParameterName);
                                        visitor.Visit(callExpre.Arguments.First());
                                        _visitString = $"({visitor.VisitString} IS NULL)";
                                    }
                                    break;
                                case "Contains":
                                    {
                                        var objectVisitor = new LambdaExpressionVisitor(ParameterName);
                                        objectVisitor.Visit(callExpre.Object);
                                        var argVisitor = new LambdaExpressionVisitor(ParameterName);
                                        argVisitor.Visit(callExpre.Arguments.First());
                                        _visitString = $"({objectVisitor.VisitString} LIKE N'%' + {argVisitor.VisitString} + N'%')";
                                    }
                                    break;
                                case "Format":
                                    if (callExpre.Arguments.Count > 1)
                                    {
                                        var formatStringVisitor = new LambdaExpressionVisitor(ParameterName);
                                        formatStringVisitor.Visit(callExpre.Arguments.First());
                                        var formatString = formatStringVisitor.VisitString;
                                        var argsVisitor = new LambdaExpressionVisitor(ParameterName);
                                        var formatMessageArgs = new List<string>();
                                        var indexAppear = new Dictionary<int, int>();
                                        var index = 0;
                                        do
                                        {
                                            var placeHolder = $"{{{index}}}";
                                            var found = true;
                                            for (var idx = 0; found;)
                                            {
                                                idx = formatString.IndexOf(placeHolder, idx);
                                                if (idx > -1)
                                                {
                                                    formatString = formatString.Remove(idx, placeHolder.Length);
                                                    formatString = formatString.Insert(idx, "%s");
                                                    indexAppear.Add(idx, index);
                                                    idx += placeHolder.Length;
                                                }
                                                else
                                                    found = false;
                                            }
                                            index++;
                                        } while (index < callExpre.Arguments.Count);

                                        var indexOrder = indexAppear.OrderBy(i => i.Key).Select(i => i.Value).ToList();

                                        var args = new List<string>();
                                        for (var i = 1; i < callExpre.Arguments.Count; i++)
                                        {
                                            argsVisitor.Visit(callExpre.Arguments[i]);
                                            args.Add(argsVisitor.VisitString);
                                        }

                                        var argsString = "";
                                        foreach (var item in indexOrder)
                                            argsString += $", {args[item]}";
                                        _visitString = $"FORMATMESSAGE({formatString}{argsString})";
                                    }
                                    break;
                                case "ToBoolean":
                                    break;
                                case "ToByte":
                                    break;
                                case "ToSByte":
                                    break;
                                case "ToChar":
                                    break;
                                case "ToDateTime":
                                    break;
                                case "ToDecimal":
                                    break;
                                case "ToDouble":
                                    break;
                                case "ToInt16":
                                    break;
                                case "ToUInt16":
                                    break;
                                case "ToInt32":
                                    break;
                                case "ToUInt32":
                                    break;
                                case "ToInt64":
                                    {
                                        var visitor = new LambdaExpressionVisitor(ParameterName);
                                        visitor.Visit(callExpre.Arguments.First());
                                        _visitString = $"CONVERT(BIGINT, {visitor.VisitString})";
                                    }
                                    break;
                                case "ToUInt64":
                                    break;
                                case "ToSingle":
                                    break;
                                case "ToString":
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case ExpressionType.Coalesce:
                        break;
                    case ExpressionType.Conditional:
                        break;
                    case ExpressionType.Constant:
                        var constant = node as ConstantExpression;
                        _visitString = $"N'{constant.Value}'";
                        break;
                    case ExpressionType.Convert:
                        break;
                    case ExpressionType.ConvertChecked:
                        break;
                    case ExpressionType.Divide:
                        _visitString = VisitBinaryExpression(node, "/");
                        break;
                    case ExpressionType.Equal:
                        _visitString = VisitBinaryExpression(node, "=");
                        break;
                    case ExpressionType.ExclusiveOr:
                        break;
                    case ExpressionType.GreaterThan:
                        _visitString = VisitBinaryExpression(node, ">");
                        break;
                    case ExpressionType.GreaterThanOrEqual:
                        _visitString = VisitBinaryExpression(node, ">=");
                        break;
                    case ExpressionType.Invoke:
                        break;
                    case ExpressionType.Lambda:
                        break;
                    case ExpressionType.LeftShift:
                        break;
                    case ExpressionType.LessThan:
                        _visitString = VisitBinaryExpression(node, "<");
                        break;
                    case ExpressionType.LessThanOrEqual:
                        _visitString = VisitBinaryExpression(node, "<=");
                        break;
                    case ExpressionType.ListInit:
                        break;
                    case ExpressionType.MemberAccess:
                        {
                            var n = node as MemberExpression;
                            if (n.Member.MemberType == System.Reflection.MemberTypes.Field &&
                                n.Member.DeclaringType.BaseType.FullName == typeof(EnumItem).FullName)
                            {
                                var type = Type.GetType($"{n.Member.DeclaringType.FullName}, {n.Member.DeclaringType.Assembly.FullName}");
                                var field = type.GetField(n.Member.Name);
                                var fieldValue = field.GetValue(null);
                                _visitString = $"N'{fieldValue}'";
                            }
                            else
                            {
                                var expVisitor = new LambdaExpressionVisitor(ParameterName);
                                expVisitor.Visit(n.Expression);
                                _visitString = $"{expVisitor.VisitString}.[{n.Member.Name}]";
                                if (n.Expression != null && n.Expression.NodeType != ExpressionType.Parameter)
                                {
                                    if (n.Member.Name == "Length")
                                    {
                                        var member = $"{node}";
                                        if (member.EndsWith(".Length"))
                                        {
                                            var idx1 = member.IndexOf(".Length");
                                            var idx2 = member.LastIndexOf(".Length");
                                            if (idx1 == idx2)
                                            {
                                                member = member.Substring(0, member.Length - ".Length".Length);
                                                _visitString = $"LEN({expVisitor.VisitString})";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case ExpressionType.MemberInit:
                        break;
                    case ExpressionType.Modulo:
                        _visitString = VisitBinaryExpression(node, "%");
                        break;
                    case ExpressionType.Multiply:
                        _visitString = VisitBinaryExpression(node, "*");
                        break;
                    case ExpressionType.MultiplyChecked:
                        break;
                    case ExpressionType.Negate:
                        break;
                    case ExpressionType.UnaryPlus:
                        break;
                    case ExpressionType.NegateChecked:
                        break;
                    case ExpressionType.New:
                        break;
                    case ExpressionType.NewArrayInit:
                        break;
                    case ExpressionType.NewArrayBounds:
                        break;
                    case ExpressionType.Not:
                        break;
                    case ExpressionType.NotEqual:
                        _visitString = VisitBinaryExpression(node, "!=");
                        break;
                    case ExpressionType.Or:
                        break;
                    case ExpressionType.OrElse:
                        _visitString = VisitBinaryExpression(node, "OR");
                        break;
                    case ExpressionType.Parameter:
                        _visitString = $"[{node}]";
                        break;
                    case ExpressionType.Power:
                        break;
                    case ExpressionType.Quote:
                        break;
                    case ExpressionType.RightShift:
                        break;
                    case ExpressionType.Subtract:
                        _visitString = VisitBinaryExpression(node, "-");
                        break;
                    case ExpressionType.SubtractChecked:
                        break;
                    case ExpressionType.TypeAs:
                        break;
                    case ExpressionType.TypeIs:
                        break;
                    case ExpressionType.Assign:
                        break;
                    case ExpressionType.Block:
                        break;
                    case ExpressionType.DebugInfo:
                        break;
                    case ExpressionType.Decrement:
                        break;
                    case ExpressionType.Dynamic:
                        break;
                    case ExpressionType.Default:
                        break;
                    case ExpressionType.Extension:
                        break;
                    case ExpressionType.Goto:
                        break;
                    case ExpressionType.Increment:
                        break;
                    case ExpressionType.Index:
                        break;
                    case ExpressionType.Label:
                        break;
                    case ExpressionType.RuntimeVariables:
                        break;
                    case ExpressionType.Loop:
                        break;
                    case ExpressionType.Switch:
                        break;
                    case ExpressionType.Throw:
                        break;
                    case ExpressionType.Try:
                        break;
                    case ExpressionType.Unbox:
                        break;
                    case ExpressionType.AddAssign:
                        break;
                    case ExpressionType.AndAssign:
                        break;
                    case ExpressionType.DivideAssign:
                        break;
                    case ExpressionType.ExclusiveOrAssign:
                        break;
                    case ExpressionType.LeftShiftAssign:
                        break;
                    case ExpressionType.ModuloAssign:
                        break;
                    case ExpressionType.MultiplyAssign:
                        break;
                    case ExpressionType.OrAssign:
                        break;
                    case ExpressionType.PowerAssign:
                        break;
                    case ExpressionType.RightShiftAssign:
                        break;
                    case ExpressionType.SubtractAssign:
                        break;
                    case ExpressionType.AddAssignChecked:
                        break;
                    case ExpressionType.MultiplyAssignChecked:
                        break;
                    case ExpressionType.SubtractAssignChecked:
                        break;
                    case ExpressionType.PreIncrementAssign:
                        break;
                    case ExpressionType.PreDecrementAssign:
                        break;
                    case ExpressionType.PostIncrementAssign:
                        break;
                    case ExpressionType.PostDecrementAssign:
                        break;
                    case ExpressionType.TypeEqual:
                        break;
                    case ExpressionType.OnesComplement:
                        break;
                    case ExpressionType.IsTrue:
                        break;
                    case ExpressionType.IsFalse:
                        break;
                    default:
                        break;
                }
            }
            return node;
        }
    }
}
