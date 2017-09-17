using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.ComponentModel;
using System;

namespace UnrealEngine
{
    public static class Extensions
    {
        public static T ToStructure<T>(this byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        public static T GetDefaultValue<T>(this PropertyInfo Property)
        {
            var attribute = Property.GetCustomAttribute(typeof(DefaultValueAttribute)) as DefaultValueAttribute;
            return (T)attribute?.Value;
        }

        public static T GetDefaultValue<T, P>(Expression<Func<T, P>> expression)
        {
            MemberExpression memberExpression = null;

            switch (expression.Body.NodeType)
            {
                case ExpressionType.MemberAccess:
                    memberExpression = expression.Body as MemberExpression;
                    break;

                case ExpressionType.Convert:
                    UnaryExpression unaryExpression = expression.Body as UnaryExpression;

                    if (unaryExpression != null)
                    {
                        memberExpression = unaryExpression.Operand as MemberExpression;
                    }
                    break;
            }

            MemberInfo member = memberExpression.Member;
            switch (member.MemberType)
            {
                case MemberTypes.Property:
                    break;
                default:
                    throw new Exception("Member is not property");
            }
            
            return ((PropertyInfo)member).GetDefaultValue<T>();
        }
    }
}